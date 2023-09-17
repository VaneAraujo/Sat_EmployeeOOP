using EmployeeOOP.Classes;

namespace EmployeeOPP.Classes {
    public class CommissionEmployee : Employee {
    
    #region Properties

        public int CommissionPercentaje {get; set;}

        public decimal Sales {get; set;}

        public decimal SalaryCom {get; set;}

    #endregion

    
    #region Methods

        public CommissionEmployee() {
        }

        BaseCommissionEmployee BaseSalary  = new BaseCommissionEmployee(); 
      
       

        public override decimal GetValueToPay() {
            SalaryCom = BaseSalary.GetValueToPay() + (Sales * (CommissionPercentaje / 100));
            return SalaryCom;
        }

        public override string ToString() {
            return $"{base.ToString()}" +
                $"Salario Total por Comisión: {SalaryCom:C2}\n\t";
        }

        #endregion
    }
}
