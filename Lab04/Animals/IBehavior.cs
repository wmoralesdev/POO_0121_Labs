using System;

namespace Lab04.Animals
{
    public interface IBehavior
    {
        // Declaracion de metodos que son comunes, pero tienen una
        // implementacion especifica
        void Eat(string food);

        void Sleep();

        void Move();
    }
}