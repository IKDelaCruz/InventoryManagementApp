using System.Collections.Generic;
using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System.Drawing;

namespace InventoryManagement.Model
{
    public class ItemSubTypeModel : BaseModel
    {
        ItemSubTypeRepository subTypeRepository;


        public ItemSubTypeModel()
        {
            subTypeRepository = new ItemSubTypeRepository();

        }

        public ReturnValueRepo CreateSubItemType(int parentId, string type)
        {
            return subTypeRepository.Create(parentId, type);
        }
        public List<ItemSubTypeViewModel> GetSubTypes()
        {
            return subTypeRepository.QuerySubTypes();
        }
        public List<ItemSubTypeViewModel> GetSubTypesByType(int itemTypeId)
        {
            return subTypeRepository.GetSubTypesByTypes(itemTypeId);
        }
        public ItemSubTypeViewModel GetSubTypeByName(string name)
        {
            return subTypeRepository.GetSubtypeByName(name);
        }
        public ItemSubTypeViewModel GetSubTypeById(int id)
        {
            return subTypeRepository.QuerySubTypeById(id);
        }
        public ReturnValueRepo Delete(int subTypeId)
        {
            return subTypeRepository.DeleteSubType(subTypeId);
        }
        public ReturnValueModel UpdateItemSubTypeImage(int itemId, Image img)
        {
            var result = new ReturnValueModel();

            byte[] bArr = Utils.ImageCon.imgToByteConverter(img);
            var success = subTypeRepository.UpdateItemTypeImage(itemId, bArr);
            result.Success = success;

            return result;
        }
        public Image GetItemSubTypeImages(int id)
        {
            var raw = subTypeRepository.GetItemImage(id);
            if (raw != null)
                return Utils.ImageCon.byteArrayToImage(raw);
            else
                return Image.FromFile(Utils.Helper.GetImageDirectory(@"\items\default.jpg"));
        }

        public List<ItemSubTypeViewModel> GetItemSubTypeImages()
        {
            return subTypeRepository.GetItemImage();
        }

    }

}
