using DataAccessLayer;
using KaravanServiceInterface;
using KaravanServiceInterface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace UIDataManager
{
    public class LogicManager
    {
        private static ChannelFactory<ILogicService> ILogicServiceAgent = new ChannelFactory<ILogicService>("LogicServiceTcpEndPoint");
        private static ILogicService iLogicService = null;

        public static List<RelatedPrice> GetMaterialCost(string materialID, CostType costType)
        {
            try
            {
                iLogicService = ILogicServiceAgent.CreateChannel();
                return iLogicService.GetMaterialCost(materialID, costType);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iLogicService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static List<RelatedPrice> GetRelatedPriceList(string itemID, string priceGroup = "Price", string reference = null)
        {
            try
            {
                iLogicService = ILogicServiceAgent.CreateChannel();
                return iLogicService.GetRelatedPriceList(itemID, priceGroup, reference);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iLogicService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }

        public static spCurrentItemMasterStockBalance_Result GetCurrentItemMasterStockBalance(string itemID, int store, DateTime enquiryDate)
        {
            try
            {
                iLogicService = ILogicServiceAgent.CreateChannel();
                return iLogicService.GetCurrentItemMasterStockBalance(itemID, store, enquiryDate);
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                var channel = iLogicService as ICommunicationObject;
                if (channel != null && channel.State == CommunicationState.Opened)
                    channel.Close();
            }
        }





    }
}
