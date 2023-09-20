using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class RatingSystem
    {
        public static int EmployeeRating(int[] EmployeeRating)
        {
            int max = EmployeeRating[0];

            for( int i = 0; i < EmployeeRating.Length; i++ )
            {
                if (max < EmployeeRating[i] )
                {
                    max = EmployeeRating[i];
                }
            }
            return max ;
        }
    public static double[] ProductsFromSuppliers(double[] ProductsFromSuppliers)
    { 

        for ( int i = 0;i < ProductsFromSuppliers.Length; i++)
        {
            ProductsFromSuppliers[i] = ProductsFromSuppliers[i] * 1.18 ;
        }
        return ProductsFromSuppliers;    
    }
        public static int SalesAmountsOfEachEmployee(int[] SalesAmountsOfEachEmployee,int plan)
        {
            int EmployeeAmount = 0;

            for ( int i = 0; i < SalesAmountsOfEachEmployee.Length;i++ )

                if(SalesAmountsOfEachEmployee[i] >= plan)
                {
                    EmployeeAmount += 1;
                }
            return EmployeeAmount;
        }
            


    }

}