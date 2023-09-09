using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ProductionCost //Service provider
    {

        public static double GetSuppliesCost( ArrayList recipeList, ArrayList productList)
        {
            double suppliesCost = 0;

            foreach (Step input in recipeList)
            {
                foreach (Product product in productList)
                {
                        suppliesCost =+ (input.Quantity/60) * product.UnitCost;
                    
                }
            } return suppliesCost;
        }

        public static double GetEquipmentCost(ArrayList recipeList, ArrayList equipmentList)
        {
            double equipmentCost = 0;

            foreach (Step instruments in recipeList)
            {
                foreach (Equipment equipment in equipmentList)
                equipmentCost =+ (instruments.Time/3600) * equipment.HourlyCost;
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