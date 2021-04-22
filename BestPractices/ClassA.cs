using System;

namespace _0_BestPractices
{
    // Class names must start with UpperCase letter
    public class ClassA
    {
        // C# Specific
        // Always prefer props instead of attributes
        // Props must start with UpperCase letter
        public string PropertyA { get; set; }
        public int PropertyB { get; set; }

        // When a prop needs to be initialized on instantiation, and the value is going to be modified
        // inside the class, use private set
        public bool PropertyC { get; private set; }

        // If attributes are used, named them with camelCase and prefer private access (use getter/setter)
        private char attr;

        // Always prefer named parameters instead of overloading constructor
        // Also, props should be avoided to be received insdide the constructor (see explanation in Main)
        // unless it's private set
        public ClassA(char attr, bool PropertyC)
        {
            // Prefer usage of this where possible
            this.attr = attr;
            this.PropertyC = PropertyC;
        }

        // Order declarations like this: attr -> prop -> constructor -> methods

    }
}