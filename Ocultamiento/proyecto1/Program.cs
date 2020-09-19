using System;

namespace proyecto2
{
    public class A
    {        
        public static void Main(string[] args)
        {
            //uso
            C c = null;
            c = new C();
            //uso
            B b = null;
            b = new B();
           
            //c
            Console.WriteLine(c.m1_c());//no contiene una definición para "m7_e", no es accesible debido a su nivel de protección
            Console.WriteLine(c.m2_c());//si
            Console.WriteLine(c.m3_c());// no es accesible debido a su nivel de protección
            Console.WriteLine(c.m4_c());//no contiene una definición para "m4_e", no es accesible debido a su nivel de protección
            Console.WriteLine(c.m5_c());// no es accesible debido a su nivel de protección
            Console.WriteLine(c.m6_c());// no es accesible debido a su nivel de protección
            Console.WriteLine(c.m7_c());//no contiene una definición para "m7_e", no es accesible debido a su nivel de protección
            //b
            Console.WriteLine(b.m1_b());//// no es accesible debido a su nivel de protección
            Console.WriteLine(b.m2_b());//si
            Console.WriteLine(b.m3_b());// no es accesible debido a su nivel de protección
            Console.WriteLine(b.m4_b());//si
            Console.WriteLine(b.m5_b());//si
            Console.WriteLine(b.m6_b());// no es accesible debido a su nivel de protección
            Console.WriteLine(b.m7_b());// no es accesible debido a su nivel de protección
        }
    }
    public class B{ 
        
    private void m1_b() {  //El acceso está limitado al tipo que lo contiene.
    }
    public void m2_b() {  //El acceso no está restringido.
    }
    protected void m3_b() {//El acceso está limitado a la clase que contiene o tipos derivados de la clase que contiene.
    }
    internal void m4_b() {//El acceso está limitado al ensamblaje actual.
    }
    protected internal void m5_b(){//El acceso está limitado al conjunto o tipos actuales derivados de la clase que lo contiene.
    }
    private protected void m6_b() {//El acceso está limitado a la clase que contiene o los tipos derivados de la clase que contiene dentro del ensamblaje actual.
    }
    void m7_b(){//El acceso está limitado al tipo que lo contiene.
    }
    }
}
