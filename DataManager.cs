using DataAccessLayer;
using KaravanServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace UIDataManager
{
    public class DataManager
    {
        private static ChannelFactory<IMainService> IMainServiceAgent = new ChannelFactory<IMainService>("MainServiceTcpEndPoint");
        private static IMainService iMainService = null;

        #region ServiceStatus
        public static DateTime GetDateTime()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.GetDateTime();
            }
            catch (Exception exception)
            {
                return DateTime.Now;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static string GetServiceVersion()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.GetServiceVersion();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static string GetServiceStatus()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                bool status = iMainService.GetServiceStatus();
                return null;
            }
            catch (Exception exception)
            {
                return exception.InnerException.Message;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region MaxIDGenerator
        public static int GetMaxItemMasterID(string prefix, int length, string suffix)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.GetMaxItemMasterID(prefix, length, suffix);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static int GetMaxOrganizationID(string prefix, int length, string suffix)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.GetMaxOrganizationID(prefix, length, suffix);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static int GetMaxPersonID(string prefix, int length, string suffix)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.GetMaxPersonID(prefix, length, suffix);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static int GetMaxDocumentID(string prefix, int length, string suffix)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.GetMaxDocumentID(prefix, length, suffix);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region ActionLog
        public static bool ActionLogDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ActionLogDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool ActionLogDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ActionLogDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int ActionLogInsert(ActionLog actionLog)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ActionLogInsert(actionLog);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int ActionLogInsertAndUpdateReferenceLastAction(ActionLog actionLog)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ActionLogInsertAndUpdateReferenceLastAction(actionLog);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<ActionLog> ActionLogSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ActionLogSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static ActionLog ActionLogSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ActionLogSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static ActionLog GetLastActionLog()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.GetLastActionLog();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static ActionLog GetLastActionLogSelectByDevice(int device)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.GetLastActionLogSelectByDevice(device);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<ActionLog> ActionLogSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ActionLogSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool ActionLogUpdate(ActionLog actionLog)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ActionLogUpdate(actionLog);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Address
        public static bool AddressDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.AddressDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool AddressDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.AddressDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int AddressInsert(Address address)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.AddressInsert(address);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Address> AddressSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.AddressSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static Address AddressSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.AddressSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Address> AddressSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.AddressSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool AddressUpdate(Address address)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.AddressUpdate(address);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region BatchItem
        public static bool BatchItemDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.BatchItemDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool BatchItemDeleteByItemID(string itemID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.BatchItemDeleteByItemID(itemID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int BatchItemInsert(BatchItem batchItem)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.BatchItemInsert(batchItem);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<BatchItem> BatchItemSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.BatchItemSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static BatchItem BatchItemSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.BatchItemSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<BatchItem> BatchItemSelectByItemID(string itemID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.BatchItemSelectByItemID(itemID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool BatchItemUpdate(BatchItem batchItem)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.BatchItemUpdate(batchItem);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region CategoryDefinition
        public static bool CategoryDefinitionDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool CategoryDefinitionDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool CategoryDefinitionDeleteByTypeAndReference(int type, string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionDeleteByTypeAndReference(type, reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int CategoryDefinitionInsert(CategoryDefinition categoryDefinition)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionInsert(categoryDefinition);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<CategoryDefinition> CategoryDefinitionSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static CategoryDefinition CategoryDefinitionSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<CategoryDefinition> CategoryDefinitionSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<CategoryDefinition> CategoryDefinitionSelectByType(int type)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionSelectByType(type);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<CategoryDefinition> CategoryDefinitionSelectByTypeAndReference(int type, string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionSelectByTypeAndReference(type, reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool CategoryDefinitionUpdate(CategoryDefinition categoryDefinition)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.CategoryDefinitionUpdate(categoryDefinition);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion
        
        #region DailyInvCtrl
        public static bool DailyInvCtrlDeleteByDocID(string docID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DailyInvCtrlDeleteByDocID(docID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int DailyInvCtrlInsert(DailyInvCtrl dailyInvCtrl)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DailyInvCtrlInsert(dailyInvCtrl);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DailyInvCtrl> DailyInvCtrlSelectByDocID(string docID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DailyInvCtrlSelectByDocID(docID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DailyInvCtrl> DailyInvCtrlSelectByItemID(string itemID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DailyInvCtrlSelectByItemID(itemID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool DailyInvCtrlUpdate(DailyInvCtrl dailyInvCtrl)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DailyInvCtrlUpdate(dailyInvCtrl);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion
        
        #region DefinitionLinker
        public static bool DefinitionLinkerDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DefinitionLinkerDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool DefinitionLinkerDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DefinitionLinkerDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int DefinitionLinkerInsert(DefinitionLinker definitionLinker)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DefinitionLinkerInsert(definitionLinker);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DefinitionLinker> DefinitionLinkerSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DefinitionLinkerSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static DefinitionLinker DefinitionLinkerSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DefinitionLinkerSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DefinitionLinker> DefinitionLinkerSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DefinitionLinkerSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool DefinitionLinkerUpdate(DefinitionLinker definitionLinker)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DefinitionLinkerUpdate(definitionLinker);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Device
        public static bool DeviceDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DeviceDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int DeviceInsert(Device device)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DeviceInsert(device);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Device> DeviceSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DeviceSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static Device DeviceSelectByDeviceName(string deviceName)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DeviceSelectByDeviceName(deviceName);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static Device DeviceSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DeviceSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool DeviceUpdate(Device device)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DeviceUpdate(device);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region DocumentBatchItem
        public static bool DocumentBatchItemDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentBatchItemDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int DocumentBatchItemInsert(DocumentBatchItem documentBatchItem)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentBatchItemInsert(documentBatchItem);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DocumentBatchItem> DocumentBatchItemSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentBatchItemSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static DocumentBatchItem DocumentBatchItemSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentBatchItemSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool DocumentBatchItemUpdate(DocumentBatchItem documentBatchItem)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentBatchItemUpdate(documentBatchItem);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region DocumentItem
        public static bool DocumentItemDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool DocumentItemDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool DocumentItemDeleteByDocID(string docID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemDeleteByDocID(docID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static int DocumentItemInsert(DocumentItem documentItem)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemInsert(documentItem);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DocumentItem> DocumentItemSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DocumentItem> DocumentItemSelectByDocID(string docID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemSelectByDocID(docID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static DocumentItem DocumentItemSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DocumentItem> DocumentItemSelectByItemID(string itemID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemSelectByItemID(itemID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DocumentItem> DocumentItemSelectByConstantAndItemID(int constant, string itemID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemSelectByConstantAndItemID(constant, itemID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<DocumentItem> DocumentItemSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool DocumentItemUpdate(DocumentItem documentItem)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentItemUpdate(documentItem);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Document
        public static bool DocumentDeleteByID(string ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool DocumentDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static string DocumentInsert(Document document)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentInsert(document);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Document> DocumentSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Document> DocumentSelectByConstant(int constant)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentSelectByConstant(constant);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Document> DocumentSelectByConstantAndDateTime(int constant, DateTime startDateTime, DateTime endDateTime, bool isIssued, bool isVoid)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentSelectByConstantAndDateTime(constant, startDateTime, endDateTime, isIssued, isVoid);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Document> DocumentSelectByConstantAndInternalDocument1(int constant, string internalDocument1)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentSelectByConstantAndInternalDocument1(constant, internalDocument1);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<Document> DocumentSelectByReferencedConstant(int referringConstant, int referencedConstant, int documentType, DateTime startDateTime, DateTime endDateTime, string referenceName, string lastState)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentSelectByReferencedConstant(referringConstant, referencedConstant, documentType, startDateTime, endDateTime, referenceName, lastState);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static Document DocumentSelectByID(string ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Document> DocumentSelectByOtherReference(string otherReference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentSelectByOtherReference(otherReference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Document> DocumentSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool DocumentUpdate(Document document)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.DocumentUpdate(document);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region IDSetting
        public static bool IDSettingDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.IDSettingDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool IDSettingDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.IDSettingDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int IDSettingInsert(IDSetting idSetting)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.IDSettingInsert(idSetting);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<IDSetting> IDSettingSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.IDSettingSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static IDSetting IDSettingSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.IDSettingSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<IDSetting> IDSettingSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.IDSettingSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool IDSettingUpdate(IDSetting idSetting)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.IDSettingUpdate(idSetting);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region ItemMaster
        public static bool ItemMasterDeleteByID(string ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ItemMasterDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static string ItemMasterInsert(ItemMaster itemMaster)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ItemMasterInsert(itemMaster);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<string> ItemMasterInsertList(List<ItemMaster> itemMasters)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ItemMasterInsertList(itemMasters);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<ItemMaster> ItemMasterSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ItemMasterSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<ItemMaster> ItemMasterSelectByConstant(int constant)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ItemMasterSelectByConstant(constant);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static ItemMaster ItemMasterSelectByID(string ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ItemMasterSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool ItemMasterUpdate(ItemMaster itemMaster)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ItemMasterUpdate(itemMaster);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region LookupDefinition
        public static bool LookupDefinitionDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.LookupDefinitionDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool LookupDefinitionDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.LookupDefinitionDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int LookupDefinitionInsert(LookupDefinition lookupDefinition)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.LookupDefinitionInsert(lookupDefinition);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<LookupDefinition> LookupDefinitionSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.LookupDefinitionSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static LookupDefinition LookupDefinitionSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.LookupDefinitionSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<LookupDefinition> LookupDefinitionSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.LookupDefinitionSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<LookupDefinition> LookupDefinitionSelectByType(int type)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.LookupDefinitionSelectByType(type);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool LookupDefinitionUpdate(LookupDefinition lookupDefinition)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.LookupDefinitionUpdate(lookupDefinition);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region MediaDetail
        public static bool MediaDetailDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MediaDetailDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool MediaDetailDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MediaDetailDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int MediaDetailInsert(MediaDetail mediaDetail)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MediaDetailInsert(mediaDetail);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<MediaDetail> MediaDetailSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MediaDetailSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static MediaDetail MediaDetailSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MediaDetailSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<MediaDetail> MediaDetailSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MediaDetailSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<MediaDetail> MediaDetailSelectByTypeAndReference(int type, string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MediaDetailSelectByTypeAndReference(type, reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool MediaDetailUpdate(MediaDetail mediaDetail)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MediaDetailUpdate(mediaDetail);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Note
        public static bool NoteDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.NoteDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool NoteDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.NoteDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static int NoteInsert(Note note)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.NoteInsert(note);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static Note NoteSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.NoteSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<Note> NoteSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.NoteSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool NoteUpdate(Note note)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.NoteUpdate(note);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Message
        public static bool MessageDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MessageDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool MessageDeleteBySender(int sender)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MessageDeleteBySender(sender);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool MessageDeleteBySenderAndIsDraft(int sender, bool isDraft)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MessageDeleteBySenderAndIsDraft(sender, isDraft);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static int MessageInsert(Message message)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MessageInsert(message);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<Message> MessageSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MessageSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static Message MessageSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MessageSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<Message> MessageSelectBySender(int sender)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MessageSelectBySender(sender);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<Message> MessageSelectBySenderAndIsDraft(int sender, bool isDraft)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MessageSelectBySenderAndIsDraft(sender, isDraft);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool MessageUpdate(Message message)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.MessageUpdate(message);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Inbox
        public static bool InboxDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool InboxDeleteByReceiver(int receiver)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxDeleteByReceiver(receiver);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool InboxDeleteByMessage(int message)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxDeleteByMessage(message);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool InboxDeleteByReceiverAndStatus(int receiver, int status)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxDeleteByReceiverAndStatus(receiver, status);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static int InboxInsert(Inbox inbox)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxInsert(inbox);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static Inbox InboxSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<Inbox> InboxSelectByReference(int receiver)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxSelectByReference(receiver);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<Inbox> InboxSelectByMessage(int message)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxSelectByMessage(message);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<Inbox> InboxSelectByReceiverAndStatus(int receiver, int status)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxSelectByReceiverAndStatus(receiver, status);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static bool InboxUpdate(Inbox inbox)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.InboxUpdate(inbox);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Organization
        public static bool OrganizationDeleteByID(string ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.OrganizationDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static string OrganizationInsert(Organization organization)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.OrganizationInsert(organization);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<string> OrganizationInsertList(List<Organization> organizations)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.OrganizationInsertList(organizations);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Organization> OrganizationSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.OrganizationSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Organization> OrganizationSelectByConstant(int constant)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.OrganizationSelectByConstant(constant);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static Organization OrganizationSelectByID(string ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.OrganizationSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool OrganizationUpdate(Organization organization)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.OrganizationUpdate(organization);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Person
        public static bool PersonDeleteByID(string ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PersonDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static string PersonInsert(Person person)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PersonInsert(person);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        public static List<string> PersonInsertList(List<Person> people)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PersonInsertList(people);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Person> PersonSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PersonSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Person> PersonSelectByConstant(int constant)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PersonSelectByConstant(constant);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static Person PersonSelectByID(string ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PersonSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool PersonUpdate(Person person)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PersonUpdate(person);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Price
        public static bool PriceDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PriceDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool PriceDeleteByItemID(string itemID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PriceDeleteByItemID(itemID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool PriceDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PriceDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int PriceInsert(Price price)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PriceInsert(price);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Price> PriceSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PriceSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static Price PriceSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PriceSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Price> PriceSelectByItemID(string itemID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PriceSelectByItemID(itemID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Price> PriceSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PriceSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool PriceUpdate(Price price)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.PriceUpdate(price);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region ReferenceLinker
        public static bool ReferenceLinkerDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ReferenceLinkerDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool ReferenceLinkerDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ReferenceLinkerDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool ReferenceLinkerDeleteByReferencedID(string referencedID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ReferenceLinkerDeleteByReferencedID(referencedID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int ReferenceLinkerInsert(ReferenceLinker referenceLinker)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ReferenceLinkerInsert(referenceLinker);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<ReferenceLinker> ReferenceLinkerSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ReferenceLinkerSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static ReferenceLinker ReferenceLinkerSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ReferenceLinkerSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<ReferenceLinker> ReferenceLinkerSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ReferenceLinkerSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<ReferenceLinker> ReferenceLinkerSelectByReferencedID(string referencedID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ReferenceLinkerSelectByReferencedID(referencedID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool ReferenceLinkerUpdate(ReferenceLinker referenceLinker)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ReferenceLinkerUpdate(referenceLinker);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Setting
        public static bool SettingDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool SettingDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool SettingDeleteByTypeAndReference(int type, string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingDeleteByTypeAndReference(type, reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool SettingDeleteByReferenceAndAttribute(string reference, string attribute)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingDeleteByReferenceAndAttribute(reference, attribute);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int SettingInsert(Setting setting)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingInsert(setting);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool SettingInsertAll(List<Setting> settings)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingInsertAll(settings);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Setting> SettingSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static Setting SettingSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<Setting> SettingSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool SettingUpdate(Setting setting)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SettingUpdate(setting);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region StockBalance
        public static bool StockBalanceDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.StockBalanceDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool StockBalanceDeleteByItemID(string itemID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.StockBalanceDeleteByItemID(itemID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int StockBalanceInsert(StockBalance stockBalance)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.StockBalanceInsert(stockBalance);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<StockBalance> StockBalanceSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.StockBalanceSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static StockBalance StockBalanceSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.StockBalanceSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<StockBalance> StockBalanceSelectByItemID(string itemID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.StockBalanceSelectByItemID(itemID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool StockBalanceUpdate(StockBalance stockBalance)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.StockBalanceUpdate(stockBalance);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region SystemConstant
        public static bool SystemConstantDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SystemConstantDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int SystemConstantInsert(SystemConstant systemConstant)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SystemConstantInsert(systemConstant);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<SystemConstant> SystemConstantSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SystemConstantSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static SystemConstant SystemConstantSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SystemConstantSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<SystemConstant> SystemConstantSelectByType(int type)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SystemConstantSelectByType(type);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool SystemConstantUpdate(SystemConstant systemConstant)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.SystemConstantUpdate(systemConstant);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region UserDetail
        public static bool UserDetailDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.UserDetailDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int UserDetailInsert(UserDetail userDetail)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.UserDetailInsert(userDetail);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<UserDetail> UserDetailSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.UserDetailSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static UserDetail UserDetailSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.UserDetailSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool UserDetailUpdate(UserDetail userDetail)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.UserDetailUpdate(userDetail);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region ValueLinker
        public static bool ValueLinkerDeleteByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ValueLinkerDeleteByID(ID);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool ValueLinkerDeleteByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ValueLinkerDeleteByReference(reference);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static int ValueLinkerInsert(ValueLinker valueLinker)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ValueLinkerInsert(valueLinker);
            }
            catch (Exception exception)
            {
                return 0;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<ValueLinker> ValueLinkerSelectAll()
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ValueLinkerSelectAll();
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static ValueLinker ValueLinkerSelectByID(int ID)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ValueLinkerSelectByID(ID);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<ValueLinker> ValueLinkerSelectByReference(string reference)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ValueLinkerSelectByReference(reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static bool ValueLinkerUpdate(ValueLinker valueLinker)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.ValueLinkerUpdate(valueLinker);
            }
            catch (Exception exception)
            {
                return false;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion

        #region Report
        public static List<vw_DocumentHeader> vw_DocumentHeaderFilter(int? constant, DateTime? startDateTime, DateTime? endDateTime, string summaryType, string reference, int? branch, string ID, int? type, string otherReference1, string otherReference2, string otherReference3, string TIN, int? category, int? group, string fileLocation, string internalDocument1, string internalDocument2, string internalDocument3, string customField1, string customField2, string customField3, string customField4, string customField5, bool? isVoid, bool? isIssued, int? sourceStore, int? destinationStore, int? lastState, int? lastUser, int? lastDevice)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.vw_DocumentHeaderFilter(constant, startDateTime, endDateTime, summaryType, reference, branch, ID, type, otherReference1, otherReference2, otherReference3, TIN, category, group, fileLocation, internalDocument1, internalDocument2, internalDocument3, customField1, customField2, customField3, customField4, customField5, isVoid, isIssued, sourceStore, destinationStore, lastState, lastUser, lastDevice);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        
        public static List<vw_LineItemHeader> vw_LineItemHeaderFilter(int? constant, DateTime? startDateTime, DateTime? endDateTime, string summaryType, string itemID, int? itemChildCategory, int? itemParentCategory, string reference, int? branch, string ID, int? type, string otherReference1, string otherReference2, string otherReference3, string TIN, int? category, int? group, string fileLocation, string internalDocument1, string internalDocument2, string internalDocument3, string customField1, string customField2, string customField3, string customField4, string customField5, bool? isVoid, bool? isIssued, int? sourceStore, int? destinationStore, int? lastState, int? lastUser, int? lastDevice)
        {
            try
            {
                iMainService = IMainServiceAgent.CreateChannel();
                return iMainService.vw_LineItemHeaderFilter(constant, startDateTime, endDateTime, summaryType, itemID, itemChildCategory, itemParentCategory, reference, branch, ID, type, otherReference1, otherReference2, otherReference3, TIN, category, group, fileLocation, internalDocument1, internalDocument2, internalDocument3, customField1, customField2, customField3, customField4, customField5, isVoid, isIssued, sourceStore, destinationStore, lastState, lastUser, lastDevice);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iMainService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }
        #endregion
        


    }
}
