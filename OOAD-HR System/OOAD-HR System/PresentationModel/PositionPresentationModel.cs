using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.PresentationModel
{
    public class PositionPresentationModel
    {

        private PositionClass _position = new PositionClass();

        // 建構子
        public PositionPresentationModel()
        {

        }

        // 設置position id
        public void SetPositionID(String positionID) 
        {
            this._position.SetId(positionID);
        }

        // 取得position id
        public String GetPositionID()
        {
            return this._position.GetId();
        }

        // 設置position name
        public void SetPositionName(String positionName)
        {
            this._position.SetName(positionName);
        }

        // 取得position name
        public String GetPositionName()
        {
            return this._position.GetName();
        }

        // 設置職位底薪
        public void SetPositionBasicSalary(float positionBS)
        {
            this._position.SetBasicSalary(positionBS);
        }

        // 取得職位底薪
        public float GetPositionBasicSalary()
        {
            return this._position.GetBasicSalary();
        }

        // 設置職位權限ID
        public void SetPositionAuthoID(String positionAuthoID)
        {
            this._position.SetAuthoId(positionAuthoID);
        }

        // 取得職位權限ID
        public String GetPositionAuthoID()
        {
            return this._position.GetAuthoId();
        }

    }
}
