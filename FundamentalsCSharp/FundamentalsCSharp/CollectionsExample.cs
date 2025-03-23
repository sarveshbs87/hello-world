using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace FundamentalsCSharp
{
    class CollectionsExample
    {
        static void Main(string[] args)
        {
            /*
            Stack stackObj = new Stack();
            stackObj.Push(10);
            stackObj.Push(20);
            stackObj.Push(30);
            stackObj.Push(40);
            stackObj.Push(50);
            stackObj.Push(60);
            Console.WriteLine("------STACK------");
            foreach (var item in stackObj)
            {
                Console.WriteLine(item);
                //sum += item;
            }

            stackObj.Pop();
            stackObj.Pop();
            //stackObj sum = 0;

            Console.WriteLine("------After 2 pops------");
            foreach (var item in stackObj)
            {
                
                Console.WriteLine(item);
                //sum += item;
            }*/

            /*
            Queue queueObj = new Queue();
            queueObj.Enqueue(25);
            queueObj.Enqueue(125);
            queueObj.Enqueue(225);
            queueObj.Enqueue(425);
            queueObj.Enqueue(625);
            Console.WriteLine("------QUEUE------");

            foreach (var item in queueObj)
            {
                Console.WriteLine(item);
            }
            queueObj.Dequeue();
            queueObj.Dequeue();

            Console.WriteLine("------After 2 dequeues------");

            foreach (var item in queueObj)
            {
                
                Console.WriteLine(item);
            }*/

            Dictionary<int, string> dictObj = new Dictionary<int, string>();
            dictObj.Add(1, "Sridharamurthy");
            dictObj.Add(2, "Savitri");
            dictObj.Add(3, "Narmada");
            dictObj.Add(4, "Rajeev");
            dictObj.Add(5, "Sarvesh");
            //dictObj.Add("Sohan", 20);

            Console.WriteLine($"Number of elements in the dictionary: {dictObj.Count}");
            Console.WriteLine($"Printing an element in the dictionary:{dictObj[3]}");
            //Console.WriteLine($"Printing an element in the dictionary:{dictObj[8]}");
            Console.WriteLine($"------DICTIONARY------");
            foreach (var item in dictObj)
            {
                Console.WriteLine($"Elements in the dictionary: {item.Key}--->>>{item.Value}");
            }
            //Console.WriteLine($"Remove an element in the dictionary:{dictObj.Remove(5)}");
            Console.WriteLine($"Remove an element in the dictionary:{dictObj.Remove(6)}");
            Console.WriteLine($"------After Removal------");
            //dictObj.Clear();
            foreach (var item in dictObj)
            {
                Console.WriteLine($"Elements in the dictionary: {item.Key}--->>>{item.Value}");
            }

            foreach (var item in dictObj.Keys)
            {
                Console.WriteLine($"All Keys: {item}");
            }

            foreach (var item in dictObj.Values)
            {
                Console.WriteLine($"All Values: {item}");
            }

            Console.ReadKey();

            //Console.WriteLine(stackObj);
            //Console.WriteLine(queueObj);
            //Console.WriteLine(dictObj);
            //Console.ReadKey();

            List<int> listObj = new List<int>();
            listObj.Add(10);
            listObj.Add(20);
            listObj.Add(30);
            listObj.Add(40);
            listObj.Add(50);

            Console.WriteLine($"------LIST------");

            Console.WriteLine($"Number of elements in the list: {listObj.Count}");

            foreach (var iteml in listObj)
            {
                Console.WriteLine(iteml);
            }

            listObj.Remove(20);
            Console.WriteLine($"------------");
            Console.WriteLine($"Number of elements after removal");

            foreach (var iteml in listObj)
            {
                Console.WriteLine(iteml);
            }



            listObj.Insert(2, 60);
            listObj.RemoveAt(4);
            Console.WriteLine($"------------");
            Console.WriteLine($"Number of elements after adding backand removing at an index");

            foreach (var iteml in listObj)
            {
                Console.WriteLine(iteml);
            }

            Console.ReadKey();

            Stack stackvar = new Stack();
            //ReturnAStack(stackvar);
            CollectionsExample collex = new CollectionsExample();
            Stack stackvarnew = collex.ReturnAStack(stackvar);
            //Console.WriteLine(stackvarnew);
            Console.WriteLine($"-------TRYOUT-------");
            foreach (var itemnew in stackvarnew)
            {
                Console.WriteLine(itemnew);
            }

            Console.ReadKey();

            List<string> listOfCountries = new List<string>();

            listOfCountries = collex.ReturnAStringList();
            foreach (var itemnewstr in listOfCountries)
            {
                Console.WriteLine(itemnewstr);
            }

            Console.ReadKey();

            ArrayList myArrlist = new ArrayList();
            myArrlist = collex.ReturnAnArrList();
            Console.WriteLine("-----------");
            foreach (var iteml in myArrlist)
            {
                Console.WriteLine(iteml);
            }
            
            Console.ReadKey();
            /*
            Array array = collex.ReturnArray();
            Console.WriteLine("-----ARRAY------");
            foreach (var iteml in array)
            {
                Console.WriteLine(iteml);
            }*/

            int[] anArr = new int[2];
            anArr[0] = 10; 
            anArr[1]=20;

            Console.WriteLine(anArr);

            Console.ReadKey();

            int[] resultsoln = collex.TwoSum([2,7,9,14,25],23);
            Console.WriteLine(resultsoln);
        }
        public Stack ReturnAStack(Stack astack)
        {
            astack = new Stack();
            astack.Push(10);
            astack.Push(20);
            astack.Push(30);
            astack.Push(40);
            astack.Push(50);
            return astack;
        }

        public List<string> ReturnAStringList()
        {
            List<string> list = new List<string>();
            list.Add("India");
            list.Add("Sri Lanka");
            list.Add("Afghanistan");
            list.Add("Israel");
            list.Add("Sweden");
            list.Add("Norway");
            list.Add("Germany");

            return list;
        }

        public ArrayList ReturnAnArrList()
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("Sarvesh");
            arrList.Add("55.7846");
            return arrList;
        }

        public Array ReturnArray()
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            return arr;


        }

        public int[] TwoSum(int[] nums, int target)
        {

            var numMap = new Dictionary<int, int>();
            var result = new int[2];

            for (var i = 0; i < nums.Length; i++)
            {
                var rightNum = target - nums[i];
                if (!numMap.ContainsKey(rightNum))
                {
                    numMap[nums[i]] = i;
                    rightNum = 0;
                }
                else
                {
                    result[0] = numMap[rightNum];
                    result[1] = i;
                    return result;
                }
            }

            return result;

        }

    }
}
