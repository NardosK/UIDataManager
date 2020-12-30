using DataAccessLayer;
using KaravanServiceInterface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIDataManager
{
    public class Library
    {
        public static string GenerateNewID(int constant, int saveOnDB, Device device)
        {
            IDSetting setting = null;
            if (device != null)
            {
                setting = DataManager.IDSettingSelectByReference(constant.ToString()).FirstOrDefault(x => x.device == device.ID);
                if (setting == null)
                {
                    setting = DataManager.IDSettingSelectByReference(constant.ToString()).FirstOrDefault();
                }
            }

            if (setting != null)
            {
                string prefix = !string.IsNullOrEmpty(setting.prefix) ? GetFormatedString(setting.prefix.Trim(), true) : (string.Empty);
                string idValue = GetFormatedCurrentValue(setting, saveOnDB);
                string suffix = !string.IsNullOrEmpty(setting.prefix) ? GetFormatedString(setting.suffix, false) : (string.Empty);
                string GeneratedId = string.Format("{0}{1}{2}", prefix, idValue, suffix);
                return GeneratedId;
            }
            else
            {
                return Constants.ID_Setting_Not_Defined;
            }
        }

        private static string GetFormatedString(string _fix, bool isPrefix)
        {
            string formatedsuffix = "";
            DateTime date = DateTime.Now;
            bool isStandardard = true;
            switch (_fix)
            {
                case "DATE":
                    formatedsuffix = date.ToString("dd");
                    break;
                case "WEEK":
                    formatedsuffix = ((int)date.DayOfWeek).ToString() + date.ToString("yy");
                    break;
                case "MO":
                    formatedsuffix = date.ToString("MM");
                    break;
                case "YYYY":
                    formatedsuffix = date.ToString("yyyy");
                    break;
                case "YY":
                    formatedsuffix = date.ToString("yy");
                    break;
                case "Device":
                    if (!string.IsNullOrEmpty(SystemBuffer.currentDevice.deviceName))
                    { formatedsuffix = SystemBuffer.currentDevice.deviceName.Replace(" ", "_"); }
                    else
                    {
                        formatedsuffix = _fix;
                        isStandardard = false;
                    }
                    break;
                case "BR":
                    if (!string.IsNullOrEmpty(SystemBuffer.currentBranch.abbreviation))
                    { formatedsuffix = SystemBuffer.currentBranch.abbreviation.Replace(" ", "_"); }
                    else
                    {
                        formatedsuffix = _fix;
                        isStandardard = false;
                    }
                    break;
                case "User":
                    if (!string.IsNullOrEmpty(SystemBuffer.currentUserDetail.userName))
                    { formatedsuffix = SystemBuffer.currentUserDetail.userName.Replace(" ", "_"); }
                    else
                    {
                        formatedsuffix = _fix;
                        isStandardard = false;
                    }
                    break;
                default:
                    formatedsuffix = _fix;
                    isStandardard = false;
                    break;
            }
            if (isStandardard)
            {
                if (isPrefix && isStandardard)
                { formatedsuffix = formatedsuffix + "-"; }
                else
                { formatedsuffix = "-" + formatedsuffix; }
            }
            return formatedsuffix;
        }

        private static string GetFormatedCurrentValue(IDSetting setting, int saveOnDB)
        {
            string formattedIDValue = "0";
            int currentValue = 0;
            switch (setting.generationStyle)
            {
                case Constants.ID_Generation_Style_CurrentValue:
                    currentValue = ++setting.currentValue;
                    if (Convert.ToBoolean(saveOnDB))
                    {
                        DataManager.IDSettingUpdate(setting);
                    }
                    return currentValue.ToString().PadLeft(setting.length, '0');
                case Constants.ID_Generation_Style_MaxID:
                    //GO TO DB AND FIND THE MAX ID FOR EACH MODULE
                    int maxID = 0;
                    switch (setting.type)
                    {
                        case Constants.ItemMasterSetting_IDSetting:
                            maxID = DataManager.GetMaxItemMasterID(setting.prefix, setting.length, setting.suffix);
                            break;
                        case Constants.PersonSetting_IDSetting:
                            maxID = DataManager.GetMaxPersonID(setting.prefix, setting.length, setting.suffix);
                            break;
                        case Constants.OrganizationSetting_IDSetting:
                            maxID = DataManager.GetMaxOrganizationID(setting.prefix, setting.length, setting.suffix);
                            break;
                        case Constants.DocumentSetting_IDSetting:
                            maxID = DataManager.GetMaxDocumentID(setting.prefix, setting.length, setting.suffix);
                            break;
                    }
                    return maxID.ToString().PadLeft(setting.length, '0');
                default:
                    return formattedIDValue;
            }
        }

    }
}
