/* 
 * Student Name: Matthew Pearce
 * StudentID: 131600732
 * Date: 19/06/2016
 * 
 * Project: AT2 Mining Simulator
 * 
 * This program monitors trucks as they travel back and forth between loading and the crusher.
 * 
 * This truck class has the following attributes,
 *   truckID – unique integer identification number
 *   capacity – the load capacity of the truck (how much ore it can carry)
 *   status – each status indicates the location of the truck
 *       0 – inactive
 *       1 – transit to loader
 *       2 – loading
 *       3 – transit to crusher
 *       4 – empty load into crusher
 *       5 – truck is in service (maintenance of truck)
 *   total – the total amount of ore the truck has carried to date
 *   inactive - tags the truck to be put back into inactive
 *   toService - tags the truck for servicing
 *   quePtr - used to point where the truck should be in a Queue
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningSimulator
{
    class Trucks
    {
        /// <summary>
        /// Truck Fields
        /// </summary>
        private int truckID;
        private int status = 0;
        private int capacity = 200;
        private int total = 0;
        private bool inactive = false;
        private bool toService = false;
        private double quePtr = 0.0;

        /// <summary>
        /// Accessor Methods
        /// </summary>
        public int gCapacity
        {
            get { return capacity; }
        }

        public int gsTruckID
        {
            get { return truckID; }
            set { truckID = value; }
        }

        public int gsStatus
        {
            get { return status; }
            set { status = value; }
        }

        public int gsTotal
        {
            get { return total; }
            set { total = value; }
        }

        public bool ToService
        {
            get { return toService; }
            set { toService = value; }
        }

        public bool ToInactive
        {
            get { return inactive; }
            set { inactive = value; }
        }

        public double gsQuePtr
        {
            get { return quePtr; }
            set { quePtr = value; }
        }

        /// <summary>
        /// Updates where the truck is within the queue.
        /// </summary>
        /// <returns></returns>
        public double QuePointerUpdate()
        {

            return quePtr -= 0.01;
        }

        /// <summary>
        /// Increments the trucks total load that it has picked up
        /// </summary>
        /// <returns></returns>
        public int IncrementTotal()
        {
            return gsTotal += capacity;
        }

        /// <summary>
        /// Changes the current status of the truck as it changes Queues or goes to Servicing
        /// </summary>
        /// <returns></returns>
        public int StsUpdate()
        {
            switch (gsStatus)
            {
                case 0:
                    return gsStatus = 1;

                case 1:
                    if (toService)
                    {
                        return gsStatus = 5;
                    }
                    else if (inactive)
                    {
                        inactive = false;
                        return gsStatus = 0;
                    }
                    else
                    {
                        return gsStatus = 2;
                    }

                case 2:
                    return gsStatus = 3;

                case 3:
                    return gsStatus = 4;

                case 4:
                    IncrementTotal();
                    if (toService)
                    {
                        return gsStatus = 5;
                    }
                    else if (inactive)
                    {
                        inactive = false;
                        return gsStatus = 0;
                    }
                    else
                    {
                        return gsStatus = 1;
                    }

                case 5:
                    if (toService)
                    {
                        return gsStatus = 5;
                    }
                    else
                    {
                        return gsStatus = 0;
                    }

                default:
                    return gsStatus = 0;
            }
        }
    }
}

