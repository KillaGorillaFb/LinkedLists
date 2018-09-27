using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       9/27/18 
/// Purpose:    Class that defines a single node of a Linked List, called LLNode.  
///             Including two data members: one integer called data and one reference to an LLNode called next.
/// </summary>
namespace LinkedListProject
{
    class LLnode
    {

        #region Class Fields
        int data;
        LLnode next;
        #endregion Class Fields

        #region Public Properties -- Getters/Setters
        public int Data { get => data; set => data = value; }
        internal LLnode Next { get => next; set => next = value; }
        #endregion Public Properties

        #region Constructors
        public LLnode(int info)
        {
            data = info;
            next = null;
        }
        #endregion Constructors

        #region Methods

        /// <summary>
        /// Methods to print Linked List Output
        /// </summary>
        public void PrintNode()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.PrintNode();
            }
        }

        /// <summary>
        /// Method that adds value to the end of the list without having to manually use next.next.next noob method
        /// </summary>
        /// <param name="data"></param>
        public void AddEnding(int data)
        {
            if(next == null)
            {
                next = new LLnode(data);
            }
            else
            {
                next.AddEnding(data);
            }
        }

        #endregion Methods
    }
}
