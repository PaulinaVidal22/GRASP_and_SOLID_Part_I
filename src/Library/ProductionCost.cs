using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ProductionCost //Service provider
    {
        public static double GetSuppliesCost(ArrayList suppliesList)
        {
            double suppliesCost = 0;

            foreach (Step step in suppliesList)
            {
                suppliesCost =+ step.Quantity * step.Input.UnitCost; //corregir, product.UnitCost colaborar con product
    
            } return suppliesCost;
        }

        public static double GetEquipmentCost(ArrayList equipmentList)
        {
            double equipmentCost = 0;

            foreach (Step step in equipmentList)
            {
                equipmentCost =+ step.Time * step.Equipment.HourlyCost;
            }
            return equipmentCost;
        }

        public static double GetProductionCost(double suppliesCost, double equipmentCost)
        {
            double productionCost = suppliesCost + equipmentCost;
            return productionCost;
        } 

    }
}

/* identificación de los esteoreotipos de las clases 
de acuerdo al principio de la responsabilidad unica (S.R.P)
, que es uno de los principios SOLID */