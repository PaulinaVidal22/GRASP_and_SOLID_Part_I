using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ProductionCost //Service provider
    {
        public static double GetProductionCost(Recipe recipe, Product product, Equipment equipment)
        {
            double suppliesCost = 0;
            IList suppliesList = recipe.GetSteps();

            foreach (Step step in suppliesList)
            {
                suppliesCost =+ step.Quantity * product.UnitCost;
    
            } return suppliesCost;
        }

        public static double GetEquipmentCost(Recipe recipe, Equipment equipment)
        {
            double equipmentCost = 0;
            IList equipmentList = recipe.GetSteps();

            foreach (Step step in equipmentList)
            {
                equipmentCost =+ step.Time * equipment.HourlyCost;
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