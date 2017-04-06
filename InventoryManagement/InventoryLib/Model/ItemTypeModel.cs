using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Model;
using InventoryManagement.ViewModel;
using InventoryManagement.Repository;
using System.Drawing;

namespace InventoryManagement.Model
{
    public class ItemTypeModel
    {
       
        ItemTypeRepository itemTypeRepository;

        public ItemTypeModel()
        {
            itemTypeRepository = new ItemTypeRepository();
        }
        public ItemTypeViewModel GetItemTypeName(string name)
        {
            return itemTypeRepository.QueryItemTypeByName(name);
        }
       public List<ItemTypeViewModel> GetTypes()
        {
            return itemTypeRepository.QueryItemTypes();
        }


        public ReturnValueRepo CreateType(string type)
        {
            return itemTypeRepository.Create(type);
        }

        public int Update(int id, string type)
        {
            return itemTypeRepository.Update(id, type);
        }

        public ReturnValueModel UpdateItemTypeImage(int itemId, Image img)
        {
            var result = new ReturnValueModel();

            byte[] bArr = Utils.ImageCon.imgToByteConverter(img);
            var success = itemTypeRepository.UpdateItemTypeImage(itemId, bArr);
            result.Success = success;

            return result;
        }

        public Image GetItemTypeImage(int id)
        {
            var raw = itemTypeRepository.GetItemIage(id);
            if (raw != null)
                return Utils.ImageCon.byteArrayToImage(raw);
            else
                return Image.FromFile(Utils.Helper.GetImageDirectory(@"\items\default.jpg"));
        }

    }
}
