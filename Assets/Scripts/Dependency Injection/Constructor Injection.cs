using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class ConstructorInjection : MonoBehaviour
    {
        
    }

    public class Unit
    {
        IMove _move;

        public Unit(IMove move)
        {
            _move = move;
        }

        public Unit()
        {
            _move = new KeybordMovement();
        }

        public string ProcessMovement(int id)
        {
            return _move.GetMovement(id);
        }
    }

    public interface IMove
    {
        string GetMovement(int id);
    }

    public class KeybordMovement : IMove
    {
        public KeybordMovement()
        {

        }

        public string GetMovement(int id)
        {
            //get the customer name from the db in real application        
            return $"Move by {this}";
        }
    }

    public class SpawnUnit
    {
        Unit _customerBL;

        public SpawnUnit()
        {
            _customerBL = new Unit(new KeybordMovement());
        }

        public string GetMovement(int id)
        {
            return _customerBL.ProcessMovement(id);
        }
    }
}
