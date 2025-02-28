using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class A : B
    {
        public A()
        {
            Console.WriteLine("A");
        }
    }
    public class B : C
    {
        public B()
        {
            Console.WriteLine("B");
        }

    }
    [AttributeUsage(AttributeTargets.All,Inherited = false,AllowMultiple = false)]
    internal sealed class OptionalAttribute : Attribute { }
    
    public class C
    {
        public string Name { get; set; }
        [Optional]
        public string NickName { get; set; }
        [Optional]
        public int ID;
        public C()
        {
            Console.WriteLine("C");
        }
        public void add()
        {
//            var intValue = null;
        }
    }

  
    public class Store
    {
        string nonNullableString = null; // Error
        string? nullableString = null;

        public static void my_mul(int num,  int num2 = 0)
        {
            Console.WriteLine(num * num2);
        }
        public static void MethodWithOptionalAttribute( string str = null)
        {
            Console.WriteLine($"str is null: {str == null}");
        }

        void abc()
        {
            C oo = new C();
            oo.NickName = null;
            oo.Name = "";
            oo.ID = 0;
        }
    }
    public class Store1
    {
        public int? MyProperty { get; set; }
        void abc()
        {
            Store.my_mul(1, 2);
            Store.my_mul(1);

            Store.MethodWithOptionalAttribute(); // str is null: True
            Store.MethodWithOptionalAttribute("abc"); // str is null: False
        }
    }

}
  
