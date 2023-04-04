namespace dotnetPractice.Classes
{
    public class AccessModifiers
    {
        private int myPrivateField;
        protected int myProtectedField;
        internal int myInternalField;
        protected internal int myProtectedInternalField;

        // The public modifier makes a type or type member accessible from any code in the same assembly or
        // from any other assembly that references the assembly containing the public type or type member.
        public void MyPublicMethod()
        {
            // ...
        }

        //  The private modifier makes a type member accessible only from code that is contained within the same class or struct as the private member.
        private void MyPrivateMethod()
        {
            // ...
        }

        // The protected modifier makes a type member accessible only from code that is contained within the same class or struct as the protected member,
        // or from a derived class.
        protected void MyProtectedMethod()
        {
            // ...
        }

        // The internal modifier makes a type or type member accessible only from within the assembly that contains the type or type member.
        internal void MyInternalMethod()
        {
            // ...
        }

        // The protected internal modifier makes a type member accessible from within the assembly in which it is declared, as well as from any derived class in any assembly.
        protected internal void MyProtectedInternalMethod()
        {
            // ...
        }
    }
}