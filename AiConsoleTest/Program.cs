using System;
using System.Dynamic;

namespace AiConsoleTest
{
    class Program
    {
        // static Test

       /* string text = "referenceType";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person = new Person();
        }*/

        // dynamic Test

        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            DynamicTest dynamicTest = new DynamicTest();

            dynamic outputObject = dynamicTest.Calulate(13);

            Console.WriteLine(outputObject.feet);
            Console.WriteLine(outputObject.inches);

        }*/

        //object Test
        static void Main(string[] args)
        {
            ObjectTest objectTest = new ObjectTest();

            MerchantModel merchantModel = new MerchantModel();
            merchantModel.id = 1;
            merchantModel.name = "Cola";

            // need typecast to get field data from object
            // can't do like this --> objectTest.ReturnObject(merchantModel).name
            // cannot type cast if not merchantModel
            MerchantModel outMerchant = (MerchantModel)objectTest.ReturnObject(merchantModel);
            Console.WriteLine(outMerchant.name);

            Console.WriteLine("-----------------------------------------"); 
            /*//CompanyModel got same field as MerchantModel but the code below will give error
            CompanyModel companyModel = (CompanyModel)objectTest.ReturnObject(merchantModel);
            Console.WriteLine(companyModel);*/

            //in my sight, object keyword is good to use for primitive type input
            int number = 10;
            string line = "Hello World";
            decimal deciNum = 1.13m;
            char word = 'A';

            Console.WriteLine(objectTest.ReturnObject(number));
            Console.WriteLine(objectTest.ReturnObject(line));
            Console.WriteLine(objectTest.ReturnObject(deciNum));
            Console.WriteLine(objectTest.ReturnObject(word));

        }
    }
}
