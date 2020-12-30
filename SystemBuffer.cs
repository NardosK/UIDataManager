using DataAccessLayer;
using KaravanServiceInterface.Data;
using ProgressInfoReporter;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDataManager
{
    public static class SystemBuffer
    {
        public static Document copiedDocument { get; set; }
        public static Device currentDevice { get; set; }
        public static CategoryDefinition defaultCategory { get; set; }
        public static CategoryDefinition headOfficeBranch { get; set; }
        public static CategoryDefinition mainStore { get; set; }
        public static CategoryDefinition adminRole { get; set; }
        public static CategoryDefinition defaultDepartment { get; set; }
        public static CategoryDefinition currentBranch { get; set; }
        public static List<Device> allDevice { get; set; }
        public static List<SystemConstant> allSystemConstant { get; set; }
        public static List<LookupDefinition> allLookupDefinition { get; set; }
        public static List<CategoryDefinition> allCategoryDefintion { get; set; }
        public static List<IDSetting> allIDSetting { get; set; }
        public static List<Setting> allSettings { get; set; }
        public static UserDetail currentUserDetail { get; set; }
        public static List<UserDetail> allUserDetail { get; set; }
        public static List<ItemMaster> allItemMaster { get; set; }
        public static List<Person> allPerson { get; set; }
        public static List<Organization> allOrganization { get; set; }
        public static List<ReferenceList> allReferenceList { get; set; }

        public static Image companyLogo;
        public static Organization currentCompany;
        public static ConcurrentBag<Task> tasks = new ConcurrentBag<Task>();
        public static List<Note> myNotes { get; set; }
        public static List<Note> openedNotes { get; set; }
        private static int currentLength = 1;
        private static int totalLength = 13;
        public static void LoadSystemBuffer(ref CustomWaitForm waitForm)
        {
            currentLength = 1;
            totalLength = 14;
            waitForm.UseWaitCursor = true;
            waitForm.progWaitForm.ShowCaption = false;
            waitForm.tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
            waitForm.tableLayoutPanel1.RowStyles[0].Height = 0;
            waitForm.pictureBox1.Visible = false;
            openedNotes = new List<Note>();
            UpdateWaitForm(waitForm, "Loading Current Company Detail . . . ");
            currentCompany = DataManager.OrganizationSelectByID(Constants.companyCode);
            UpdateWaitForm(waitForm, "Loading Registered Devices . . . ");
            allDevice = DataManager.DeviceSelectAll();
            UpdateWaitForm(waitForm, "Loading System Constants . . . ");
            allSystemConstant = DataManager.SystemConstantSelectAll();
            UpdateWaitForm(waitForm, "Loading System Lookup Defintions . . . ");
            allLookupDefinition = DataManager.LookupDefinitionSelectAll();
            UpdateWaitForm(waitForm, "Loading System Category Defintions . . . ");
            allCategoryDefintion = DataManager.CategoryDefinitionSelectAll();
            UpdateWaitForm(waitForm, "Populating default data . . . ");
            defaultCategory = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.DefaultCategory);
            headOfficeBranch = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.HeadOffice);
            mainStore = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.MainStore);
            adminRole = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.AdminRole);
            defaultDepartment = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.DefaultDepartment);
            currentBranch = allCategoryDefintion.FirstOrDefault(p => p.ID == currentDevice.branch);
            if (currentCompany != null)
            {
                if (File.Exists(currentCompany.mediaURL))
                { companyLogo = new Bitmap(currentCompany.mediaURL); }
            }
            UpdateWaitForm(waitForm, "Loading System ID Settings . . . ");
            allIDSetting = DataManager.IDSettingSelectAll();
            UpdateWaitForm(waitForm, "Loading System Settings . . . ");
            allSettings = DataManager.SettingSelectAll();
            UpdateWaitForm(waitForm, "Loading System User Details . . . ");
            allUserDetail = DataManager.UserDetailSelectAll();
            UpdateWaitForm(waitForm, "Loading System Item Master . . . ");
            allItemMaster = DataManager.ItemMasterSelectAll();
            UpdateWaitForm(waitForm, "Loading System Person . . . ");
            allPerson = DataManager.PersonSelectAll();
            UpdateWaitForm(waitForm, "Loading System Organizations . . . ");
            allOrganization = DataManager.OrganizationSelectAll();
            UpdateWaitForm(waitForm, "Loading ReferenceList . . . ");
            allReferenceList = PopulateReferenceList();

            currentLength = totalLength;
            UpdateWaitForm(waitForm, "Ready to Go!");
            waitForm.UseWaitCursor = false;
            waitForm.progWaitForm.LineAnimationElementHeight = 0;
            waitForm.progWaitForm.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
        }

        public static List<ReferenceList> PopulateReferenceList(int? referenceType = null)
        {
            List<ReferenceList> allReferences = new List<ReferenceList>();
            if (referenceType != null && allReferenceList != null && allReferenceList.Count > 0)
            {
                allReferenceList.RemoveAll(p => p.referenceType == referenceType.Value);
                if (allReferenceList != null && allReferenceList.Count > 0)
                { allReferences = allReferenceList; }
            }

            if (referenceType == null || referenceType == Constants.DatabaseObject_Person)
            {
                allReferences.AddRange(allPerson.Where(p => p.constant != 0).Select(person => new ReferenceList
                {
                    ID = person.ID,
                    referenceType = Constants.DatabaseObject_Person,
                    constant = person.constant,
                    name = person.name,
                    category = person.category,
                    taxType = person.taxType,
                    defaultID = person.defaultID,
                    isActive = person.isActive,
                    defaultState = person.defaultState
                }).ToList());
                allReferences.ForEach(p => p.defaultID = allUserDetail.FirstOrDefault(u => u.empID == p.ID) != null ? allUserDetail.FirstOrDefault(u => u.empID == p.ID).userName : "");
            }

            if (referenceType == null || referenceType == Constants.DatabaseObject_Organization)
            {
                allReferences.AddRange(allOrganization.Where(p => p.constant != 0).Select(organization => new ReferenceList
                {
                    ID = organization.ID,
                    referenceType = Constants.DatabaseObject_Organization,
                    constant = organization.constant,
                    name = organization.name,
                    category = organization.category,
                    taxType = organization.taxType,
                    defaultID = organization.defaultID,
                    isActive = organization.isActive,
                    defaultState = organization.defaultState
                }).ToList());
            }

            if (referenceType == null || referenceType == Constants.DatabaseObject_ItemMaster)
            {
                allReferences.AddRange(allItemMaster.Where(p => p.constant != 0).Select(itemMaster => new ReferenceList
                {
                    ID = itemMaster.ID,
                    referenceType = Constants.DatabaseObject_ItemMaster,
                    constant = itemMaster.constant,
                    name = itemMaster.name,
                    category = itemMaster.category,
                    taxType = itemMaster.taxType,
                    defaultID = itemMaster.UOM.ToString(),
                    isActive = itemMaster.isActive,
                    defaultState = itemMaster.defaultState
                }).ToList());
            }
            return allReferences;
        }

        public static bool LoadSystemBuffer()
        {
            try
            {
                currentLength = 1;
                totalLength = 13;
                //InfoReporter.Show("Loading Current Company Detail . . . ", currentLength++, totalLength);
                //currentCompany = DataManager.OrganizationSelectByID(Constants.companyCode);
                //InfoReporter.Show("Loading System Devices . . . ", currentLength++, totalLength);
                //allDevice = DataManager.DeviceSelectAll();
                //InfoReporter.Show("Loading System Constants . . . ", currentLength++, totalLength);
                //allSystemConstant = DataManager.SystemConstantSelectAll();
                //InfoReporter.Show("Loading System Lookup Defintions . . . ", currentLength++, totalLength);
                //allLookupDefinition = DataManager.LookupDefinitionSelectAll();
                //InfoReporter.Show("Loading System Category Defintions . . . ", currentLength++, totalLength);
                //allCategoryDefintion = DataManager.CategoryDefinitionSelectAll();
                //InfoReporter.Show("Populating default data . . . ", currentLength++, totalLength);
                //defaultCategory = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.DefaultCategory);
                //headOfficeBranch = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.HeadOffice);
                //mainStore = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.MainStore);
                //adminRole = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.AdminRole);
                //defaultDepartment = allCategoryDefintion.FirstOrDefault(p => p.ID == Constants.DefaultDepartment);
                //currentBranch = allCategoryDefintion.FirstOrDefault(p => p.ID == currentDevice.branch);
                //MediaDetail companyLogo = DataManager.MediaDetailSelectByTypeAndReference(Constants.MediaType_Logo, Constants.companyCode).FirstOrDefault();
                //if (companyLogo != null)
                //{
                //    if (File.Exists(companyLogo.url))
                //    { SystemBuffer.companyLogo = new Bitmap(companyLogo.url); }
                //}
                //InfoReporter.Show("Loading System ID Settings . . . ", currentLength++, totalLength);
                //allIDSetting = DataManager.IDSettingSelectAll();
                //InfoReporter.Show("Loading System Settings . . . ", currentLength++, totalLength);
                //allSettings = DataManager.SettingSelectAll();
                InfoReporter.Show("Loading My Notes . . . ", currentLength++, totalLength);
                myNotes = DataManager.NoteSelectByReference(currentUserDetail.ID.ToString());
                //InfoReporter.Show("Loading System User Details . . . ", currentLength++, totalLength);
                //allUserDetail = DataManager.UserDetailSelectAll();
                InfoReporter.Show("Loading System Item Master . . . ", currentLength++, totalLength);
                allItemMaster = DataManager.ItemMasterSelectAll();
                InfoReporter.Show("Loading System Person . . . ", currentLength++, totalLength);
                allPerson = DataManager.PersonSelectAll();
                InfoReporter.Show("Loading System Organizations . . . ", currentLength++, totalLength);
                allOrganization = DataManager.OrganizationSelectAll();
                InfoReporter.Show("Loading ReferenceList . . . ", currentLength++, totalLength);
                allReferenceList = PopulateReferenceList();
                InfoReporter.Show("Completed Loading System Buffers.", totalLength, totalLength);

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private static void UpdateWaitForm(CustomWaitForm waitForm, string description)
        {
            waitForm.SetDescription(description);
            if (totalLength > 0 && currentLength <= totalLength)
            {
                int currentValue = (currentLength * 100) / totalLength;
                waitForm.pbcMain.Position = currentValue;
            }
            currentLength++;
        }

        public static int GetUncompletedMethods()
        {
            int i = tasks.Where(x => (x != null) && (x.Status != TaskStatus.RanToCompletion)).Count();
            return i;
        }
        public static int GetCompletedMethods()
        {
            int i = tasks.Where(x => x.Status == TaskStatus.RanToCompletion).Count();
            return i;
        }






    }
}
