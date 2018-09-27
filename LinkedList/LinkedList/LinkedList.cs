using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       9/27/18 
/// Purpose:    Class that defines a Linked List, called LinkedList.  
///             Containing three LLNode pointer/reference data members: front, back, and current. 
/// </summary>
namespace LinkedListProject
{
    class LinkedList
    {
        #region Class Fields
        private LLnode front;
        private LLnode back;
        private LLnode current;
        #endregion Class Fields

        #region Getters/ Setters
        internal LLnode Front { get => front; set => front = value; }
        internal LLnode Back { get => back; set => back = value; }
        internal LLnode Current { get => current; set => current = value; }
        #endregion Getters/ Setters

        #region Constructors
        public LinkedList()
        {
            front = null;
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Method to add new value/ node to end of the list
        /// </summary>
        /// <param name="data"></param>
        public void AddEnding(int data)
        {
            if (front == null)
            {
                front = new LLnode(data);
            }
            else
            {
                front.AddEnding(data);
            }
        }//End of public void AddEnding(int data)

        /// <summary>
        /// Method to add new value/ node to front of the list
        /// </summary>
        /// <param name="data"></param>
        public void AddToFront(int data)
        {
            if  (front == null)
            {
                front = new LLnode(data);
            }
            else
            {
                LLnode temp = new LLnode(data);
                temp.Next = front;
                front = temp;
            }
        }

        /// <summary>
        /// Method to print created list
        /// </summary>
        public void Print()
        {
            if(front != null)
            {
                front.PrintNode();
            }
        }

        #endregion Methods
        
    }
}
