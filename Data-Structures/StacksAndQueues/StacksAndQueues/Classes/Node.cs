﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node
    {
        //node properties
        public int Value { get; set; }
        public Node Next { get; set; }

        //Node constructor
        public Node(int value)
        {
            Value = value;
        }
    }
}
