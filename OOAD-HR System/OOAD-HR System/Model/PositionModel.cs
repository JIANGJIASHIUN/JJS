using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Class;

namespace OOAD_HR_System.Model
{
    public class PositionModel
    {

        private PositionClass _positionClass = new PositionClass();

        // 建構子
        public PositionModel()
        {

        }

        // ---------------------------------------------設置id---------------------------------------------
        public void SetId(String positionID)
        {
           this. _positionClass.SetId(positionID);    
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String GetId()
        {
            return this._positionClass.GetId();
        }

        // ---------------------------------------------設置職稱---------------------------------------------
        public void SetName(String positionName)
        {
            this._positionClass.SetName(positionName);
        }

        // ---------------------------------------------取得職稱---------------------------------------------
        public String GetName()
        {
            return this._positionClass.GetName();
        }

        // ---------------------------------------------設置職位底薪---------------------------------------------
        public void SetBasicSalary(float positionBasicSalary)
        {
            this._positionClass.SetBasicSalary(positionBasicSalary);
        }

        // ---------------------------------------------取得職位底薪---------------------------------------------
        public float GetBasicSalary()
        {
            return this._positionClass.GetBasicSalary();
        }

        // ---------------------------------------------設置權限id---------------------------------------------
        public void SetAuthoId(String authoID)
        {
            this._positionClass.SetAuthoId(authoID);
        }

        // ---------------------------------------------取得權限id---------------------------------------------
        public String GetAuthoId()
        {
            return this._positionClass.GetAuthoId();
        }

    }
}
