
using AutoMapper;
using System;
using System.Collections.Generic;
using Test.AbstractFactoryPattern;
using Test.CommandDesignPattern;
using Test.AbstractFactoryPattern.practice;
using Test.BuilderPattern;
using Test.BuilderPattern.practice;
using Test.FactoryMethodPattern;
using Test.FactoryMethodPattern.practice;
using Test.PrototypePattern;
using Test.PrototypePattern.practice;
using Test.SingletonPattern;
using Test.AdapterPattern;
using Test.AdapterPattern.practice;
using Test.BridgePattern;
using Test.BridgePattern.practice;
using Test.CompositePattern;
using Test.CompositePattern.practice;
using Test.DecoratePattern;
using Test.DecoratePatterns;
using Test.DecoratorPattern.practice;
using Test.Model;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.SqlTypes;
using Test.utils_HackerRank;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;
using Test.Constants;
using Microsoft.VisualBasic;
using Test.Constants;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Text;
using static Test.utils_HackerRank.helperFunc_HuffmanDecoding;
using static Test.utils_HackerRank.helperFunc_OrganizingContainersBalls;
using static Test.utils_HackerRank.helperFunc_SwapNodes;
using System.Collections;
using Microsoft.Extensions.Primitives;
using System.Dynamic;
using static Test.utils_HackerRank.helperFunc_IsBinarySearchTree;
using static Test.utils_HackerRank.helperFunc_BalancedForest;
using static Test.utils_HackerRank.helperFunc_JennySubtrees;
using static Test.utils_HackerRank.helperFunc_SelfBalancingAVLtree;

public class Program
{
    public static void Main()
    {
        // Console.WriteLine("//---------------Abstract Factory Pattern -------------------");
        // var ClientMethod = new ClientMethod();
        // Console.WriteLine("Client: Testing client code with the first factory type...");
        // ClientMethod._ClientMethod(new ConcreteFactory1());
        // Console.WriteLine();

        // Console.WriteLine("Client: Testing the same client code with the second factory type...");
        // ClientMethod._ClientMethod(new ConcreteFactory2());

        // Console.WriteLine("//---------------Abstract Factory Pattern Practice-------------------");
        // var ClientMethodPractice = new ClientMethodPractice();
        // Console.WriteLine("Factory 1: ............");
        // ClientMethodPractice._ClientMethodPractice(new VictorianFactory());

        // Console.WriteLine("Factory 2: ............");
        // ClientMethodPractice._ClientMethodPractice(new ModernFactory());

        // Console.WriteLine("Factory 3: ............");
        // ClientMethodPractice._ClientMethodPractice(new ArtDecoFactory());



        // Console.WriteLine("//---------------Builder Pattern -------------------");
        // Director director = new Director();
        // ConcreteBuilder builder = new ConcreteBuilder();
        // director.setBuilder(builder);

        // Console.WriteLine("Standard basic product: ");
        // director.buidMinimalViableProduct();
        // Console.WriteLine(builder.getProduct().ListParts());

        // Console.WriteLine("Stadard full featured product: ");
        // director.BuildFullFeaturedProduct();
        // Console.WriteLine(builder.getProduct().ListParts());
        // //Remember , the builder pattern can be used without a Director class
        // Console.WriteLine("Custon product: ");
        // builder.BuildPartA();
        // builder.BuildPartC();
        // Console.WriteLine(builder.getProduct().ListParts());

        // Console.WriteLine("//---------------Builder Pattern Practice-------------------");
        // ComputerDirector computerDirector = new ComputerDirector();

        // IComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
        // computerDirector.setBuilder(gamingComputerBuilder);
        // Console.WriteLine("Gaming computer: " + computerDirector.BuildComputer().ListParts());

        // IComputerBuilder officeComputerBuilder = new OfficeComputerBuilder();
        // computerDirector.setBuilder(officeComputerBuilder);
        // Console.WriteLine("Office computer: " + computerDirector.BuildComputer().ListParts());



        // Console.WriteLine("//---------------Factory Method Pattern-------------------");
        // ClientCode clientCode = new ClientCode();
        // Console.WriteLine("App: Launched with the ConcreteCreator1");
        // clientCode._ClientCode(new ConcreteCreator1());
        // Console.WriteLine("");
        // Console.WriteLine("App: Launched with the ConcreteCreator2");
        // clientCode._ClientCode(new ConcreteCreator2());
        // Console.WriteLine("//---------------Factory Method Pattern Practice-------------------");
        // ClientCodePractice clientcode = new ClientCodePractice();
        // Console.WriteLine("[ReportCreator]: ");
        // clientcode._clientCode(new ReportCreator());
        // Console.WriteLine("");
        // Console.WriteLine("[InvoiceCreator]: ");
        // clientcode._clientCode(new InvoiceCreator());


        // Console.WriteLine("//---------------Prototype Pattern-------------------");
        // ClientCodePrototype clientCodePrototype = new ClientCodePrototype();
        // clientCodePrototype._ClientCodePrototype();
        // Console.WriteLine("//---------------Prototype Pattern Practice-------------------");
        // ClientCodeShapePrototype clientCodeShapePrototype = new ClientCodeShapePrototype();
        // clientCodeShapePrototype._clientCodeShapePrototype();


        // Console.WriteLine("//---------------Singleton Pattern-------------------");
        // clientCodeSingletonPattern clientCodeSingleton = new clientCodeSingletonPattern();
        // clientCodeSingleton._clientCodeSingletonPattern();


        // Console.WriteLine("//---------------Adapter Pattern-------------------");
        // ClientCode_Apdapter clientCodeAdapter = new ClientCode_Apdapter();
        // clientCodeAdapter.clientCodeAdapter();
        // Console.WriteLine("//---------------Adapter Pattern Practice-------------------");
        // clientCode_Adapter_Practice clientCodeAdapterPractice = new clientCode_Adapter_Practice();
        // clientCodeAdapterPractice._clientCode_Adapter_Practice();


        // Console.WriteLine("//---------------Bridge Pattern-------------------");
        // Client_Bridge clientCode_Bridge = new Client_Bridge();
        // Abstraction abstraction;
        // abstraction = new Abstraction(new ConcreteImplementationA());
        // clientCode_Bridge.ClientCode(abstraction);
        // Console.WriteLine();
        // abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
        // clientCode_Bridge.ClientCode(abstraction);
        // Console.WriteLine("//---------------Bridge Pattern Practice-------------------");
        // ClientCode_Bridge_Practice clientBridgePractice = new ClientCode_Bridge_Practice();
        // clientBridgePractice._ClientCode_Bridge_Practice();


        // Console.WriteLine("//---------------Composite Pattern-------------------");
        // ClientCompositePattern clientComposite = new ClientCompositePattern();
        // // This way the client code can support the single leaf
        // //components...
        // Leaf leaf = new Leaf();
        // Console.WriteLine("Client: I get a single component:");
        // clientComposite._ClientCode(leaf);
        // //...as well as the complex composites
        // Composite tree = new Composite();
        // Composite branch1 = new Composite();
        // branch1.Add(new Leaf());
        // branch1.Add(new Leaf());
        // Composite branch2 = new Composite();
        // branch2.Add(new Leaf());
        // tree.Add(branch1);
        // tree.Add(branch2);
        // Console.WriteLine("Client: Now I've got a composite tree");
        // clientComposite._ClientCode(tree);
        // Console.WriteLine("Client: I don't need to check the components classes even when managing the tree:\n");
        // clientComposite._ClientCode2(tree, leaf);
        // Console.WriteLine("//---------------Composite Pattern Practice-------------------");
        // ClientCompositePatternPractice clientCompositePatternPractice = new ClientCompositePatternPractice();
        // clientCompositePatternPractice._ClientCompositePattern();


        // Console.WriteLine("//---------------Decorator Pattern-------------------");
        // ClientDecoratePattern clientDecoratorPattern = new ClientDecoratePattern();

        // var simple = new ConcreteComponent();
        // Console.WriteLine("Client: I get a simple component:");
        // clientDecoratorPattern.ClientCode(simple);
        // Console.WriteLine();

        // // --wrap more decorator
        // ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
        // ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
        // Console.WriteLine("Client: Now I've got a decorated component:");
        // clientDecoratorPattern.ClientCode(decorator2);
        // Console.WriteLine("//---------------Decorator Pattern Practice-------------------");
        // ClientCodeDecoratorPatternPractice clientDecoratePatternPractice = new ClientCodeDecoratorPatternPractice();
        // clientDecoratePatternPractice._clientCode();


        // // test loop object
        // Console.WriteLine("----------------Test loop object----------------");
        // // PersonModel person = new PersonModel
        // // {
        // //     Name = "nam",
        // //     Age = 23,
        // //     Objects = new List<string> { "math", "physics" },
        // //     Detail = new PersonModel.PersonDetail
        // //     {
        // //         Address = "this  is an address",
        // //         Phone = "1234567890",
        // //         Email = "this is an email address",
        // //     }
        // // };
        // var person = new
        // {
        //     Name = "nam",
        //     Age = 23,
        //     Objects = new List<string> { "math", "physics" },
        // };

        // string jsonData = JsonConvert.SerializeObject(person);

        // // Parse the JSON object
        // JObject jsonObject = JObject.Parse(jsonData);

        // Console.WriteLine("person............", jsonObject);
        // // Console.WriteLine(person.GetType().GetProperties());
        // var props = person.GetType().GetProperties();
        // Console.WriteLine($"----------------------{jsonObject["Name"]} - {jsonObject["Age"]}");
        // foreach (PropertyInfo prop in props)
        // {
        //     // if (prop.GetType() == typeof(List<string>))
        //     // {
        //     //     Console.WriteLine("check");
        //     //     Console.WriteLine(prop.GetValue(person));
        //     // }

        //     Console.WriteLine(prop.GetValue(person));

        //     if (prop.GetType() == typeof(PersonModel.PersonDetail))
        //     {
        //         Console.WriteLine("check");
        //     }
        // }



        //----------------PROBLEM SOLVING - HACKER RANK---------------------
        //Plus minus problem
        //compare the triplet
        //AveryBigSum
        int[] arr = new int[5] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
        helperFunc_BigSum bigSumHelper = new helperFunc_BigSum();
        Console.WriteLine(bigSumHelper.BigSum(arr));

        //Staircase 
        //Mini_max_Sum
        //BirthDay_Cake_Candles
        //TimeConversion
        string time = "07:05:45PM";
        Print print = new Print();
        helperFunc_TimeConversion TimeConversionHelper = new helperFunc_TimeConversion();
        Console.WriteLine(TimeConversionHelper.TimeConversion(time));
        // Console.WriteLine(TimeConversionHelper.SimplyParseExact(time));///// ***

        //gradingProblem
        //AppleAndOrange
        //NumberLineJump
        //BetweenTwoSets
        int[] arr1 = new int[2] { 2, 4 };
        int[] arr2 = new int[3] { 16, 32, 96 };
        helperFunc_between2Set between2Set = new helperFunc_between2Set();
        Console.WriteLine("between2Set result: " + between2Set.betweenTwoSet(arr1, arr2));

        //breakingRecord
        //SunarrayDivision
        //DivisibleSumPair => chua optimze duoc van O(n^2)
        //MigratoryBirds
        //DayOfTheProgrammer
        int year = 1800;
        helperFunc_DayOfProgramer dayProgrmer = new helperFunc_DayOfProgramer();
        Console.WriteLine("dayOfTheProgramer result: " + dayProgrmer.dayOfTheProgramer(year));

        //BillDivision
        //SaleByMNatch
        int[] arr3 = new int[9] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        helperFunc_SaleByMatch saleByMatchHelper = new helperFunc_SaleByMatch();
        Console.WriteLine("SaleByMNatch result: " + saleByMatchHelper.SaleByMatchUseLinq(arr3));

        //DrawingBook
        //CountingValley
        //ElectronicShop
        //CatsAndMouse
        //magicSquareForming
        //pickingNumber
        //ClimbingLeaderboard
        int[] ranked = new int[7] { 100, 100, 50, 40, 40, 20, 10 };
        int[] player = new int[4] { 5, 25, 50, 120 };
        helperFunc_ClimbLeaderboard climbLeaderboard = new helperFunc_ClimbLeaderboard();
        Console.Write("getArrRankOrder result: ");
        print.PrintArrInt(climbLeaderboard.ClimbLeaderboard(ranked, player));
        Console.WriteLine();

        //hurdleRace
        //utopianTree
        //AngryProfessor
        //BeautifulDayAtTheMovie
        int startingDay = 20;
        int endingDay = 23;
        int divisor = 6;
        helperFunc_BeautifulDayAtTheMovie beautifulDayHelper = new helperFunc_BeautifulDayAtTheMovie();
        Console.WriteLine("BeautifulDayAtTheMovie: " + beautifulDayHelper.BeautifulDayAtTheMovie(startingDay, endingDay, divisor));

        //viralAdvertising
        //SaveThePrisioner
        //CircularArrayRotation
        //SequenceEquation
        //JumpOnThe:Cloud
        //Findigits
        //ExtraLongFatorial
        //AppendAndDelete
        //SherlockAndSquares
        //LibraryFine
        //CutTheSticks
        //NonDivisibleSubset
        //RepeatedString
        //JumpOnTheCloud
        //EqualizeArray
        //QueenAttack
        int numberOfRowsColumns = 5;
        // int numOfObstacles = 3;
        int[] queenPosition = new int[2] { 4, 3 };
        int[][] obstacles = new int[][] {
            new int[2] {5,5},
            new int[2] {4,2},
            new int[2] {2,3},
        };
        helperFunc_QueenAttack queenHelper = new helperFunc_QueenAttack();
        Console.WriteLine("QueenAttack result: " + queenHelper.QueenAttack(numberOfRowsColumns, queenPosition, obstacles));

        //ICMICPCTeam
        //TaumAndBDay
        //OganizingContainersOfBalls
        int numContainersTypes = 2;

        List<TestCase> allTestCase = new List<TestCase>()
        {
            new TestCase(numContainersTypes, new List<int>() { 1, 1, 1, 1 }),
            new TestCase(numContainersTypes, new List<int>() { 0, 2, 1, 1 }),
            new TestCase(3, new List<int>() { 1, 3, 1, 2, 1, 2, 3, 3, 3 }),
            new TestCase(3, new List<int>() { 0, 2, 1, 1, 1, 1, 2, 0,0 }),
        };
        Console.WriteLine("OganizingContainersOfBalls result: ");
        helperFunc_OrganizingContainersBalls containersBallsHelper = new helperFunc_OrganizingContainersBalls();
        foreach (string item in containersBallsHelper.OganzingContainersBalls(numberOfRowsColumns, allTestCase))
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        //encryption
        //BiggerIsGreater
        //KaprekarNumbers
        //BeautifulTriplet
        //MinimunDistance
        //HalloweenSale
        //TheTimeInWords
        //








        Console.WriteLine();
        //----------------DATA STRUCTURE - HACKER RANK-----------------
        //2D-Array
        string[] stringList = new string[3] { "ab", "ab", "abc" };
        string[] queries = new string[3] { "ab", "abc", "bc" };
        helperFunc_2DArray twoDArrayHelper = new helperFunc_2DArray();
        print.PrintArrInt(twoDArrayHelper.twoDArray(stringList, queries));

        // Array MAnipulation
        Console.WriteLine("Array MAnipulation");
        int n = 5;
        int m = 3;
        int[][] queriesM = new int[][]{
            new int[]{1, 2, 100},
            new int[]{2, 5, 100},
            new int[]{3, 4, 100},
        };
        // print.PrintArrInt(ArrayManipulation(n, m, queriesM));
        helperFunc_ArrManipulation ArrManipulateHelper = new helperFunc_ArrManipulation();
        Console.WriteLine(ArrManipulateHelper.ArrayManipulation(n, m, queriesM));

        //cycle detection
        //TreeHuffmanDecoding --> get rif of the encoding algorithm --> just create a tree as a resulting of encoding and try to decode
        string str = "1001011";

        TreeEncoding tree = new TreeEncoding(new TreeNode("null", 5));
        tree.AddTreeNode(tree._root, "null", 2, "0 ");
        tree.AddTreeNode(tree._root, "A", 3, "1 ");
        tree.AddTreeNode(tree._root, "B", 1, "00 ");
        tree.AddTreeNode(tree._root, "C", 1, "01 ");

        Console.Write("tree tranverse........: ");
        tree.TranverseTree(tree._root);
        Console.Write("decode........: " + tree.Decode(str));

        //swapNode
        int numOfNodes = 11;
        int[][] arrCreateNode = new int[][] {
            new int [2] {2,3},
            new int [2] {4,-1},
            new int [2] {5,-1},
            new int [2] {6,-1},
            new int [2] {7,8},
            new int [2] {-1,9},
            new int [2] {-1,-1},
            new int [2] {10,11},
            new int [2] {-1,-1},
            new int [2] {-1,-1},
            new int [2] {-1,-1},
        };
        int[] queriesNew = new int[2] { 2, 4, };
        helperFunc_SwapNodes swapNodeHelper = new helperFunc_SwapNodes();
        List<List<int>> swapTree = swapNodeHelper.SwapNode(numOfNodes, arrCreateNode, queriesNew);
        Console.WriteLine("Swap tree result:.....");
        foreach (var i in swapTree)
        {
            foreach (var j in i)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        //KittyCalOnTree
        int numOfpaths = 7;
        int[][] edges = new int[][]{
            new int[2]{1, 2},
            new int[2]{1, 3},
            new int[2]{1, 4},
            new int[2]{3, 5},
            new int[2]{3, 6},
            new int[2]{3, 7},
        };
        int numOfSets = 3;
        int numOfSet1 = 2;
        int[] set1 = new int[2] { 2, 4 };
        int numOfSet2 = 1;
        int[] set2 = new int[1] { 5 };
        int numOfSet3 = 3;
        int[] set3 = new int[3] { 2, 4, 5 };

        helperFunc_KittyCalculation KittyHelper = new helperFunc_KittyCalculation();
        List<double> KittyResultList = KittyHelper.KittyCalculation(
            numOfpaths,
            edges,
            numOfSets,
            numOfSet1,
            set1,
            numOfSet2,
            set2,
            numOfSet3,
            set3
        );
        Console.WriteLine("KittyCalOnTree resut: ");
        foreach (double item in KittyResultList)
        {
            Console.Write(item + " ");
        }

        //__(Bonus)_ImplementDijkstraAlgorithm
        helperFunc_Graph_Dijkstra dijkstraAlHelper = new helperFunc_Graph_Dijkstra();
        int numOfNodesGraph = 5;
        int[][] edgesGraph = new int[][]{
            new int[3]{0, 1, 10},
            new int[3]{0, 4, 5},
            new int[3]{1, 2, 1},
            new int[3]{1, 4, 2},
            new int[3]{2, 3, 4},
            new int[3]{3, 0, 7},
            new int[3]{3, 2, 6},
            new int[3]{4, 1, 3},
            new int[3]{4, 2, 9},
            new int[3]{4, 3, 2},
        };
        dijkstraAlHelper.RunDijkstraAl(numOfNodesGraph, edgesGraph);

        //IsBinarySearchTree
        Console.WriteLine();
        BinaryTreeNode root = new BinaryTreeNode(3);
        BinaryTree treeNew = new BinaryTree(root);
        treeNew.AddNode(root, 5);
        treeNew.AddNode(root, 2);
        treeNew.AddNode(root, 1);
        treeNew.AddNode(root, 4);
        treeNew.AddNode(root, 6);
        Console.Write("Tranvers binary tree result: .............");
        treeNew.TranversTree(root);
        Console.WriteLine("check binary tree: ....." + treeNew.CheckIsBinaryTree(root));

        //SquareTenTree
        // int L = 1;
        // int R = 10;
        // Console.WriteLine("SquareTenTree result: ................");
        // helperFunc_SquareTenTree squareTenTreeHelper = new helperFunc_SquareTenTree();
        // List<(int, int)> result = squareTenTreeHelper.SquareTenTree(L, R);
        // foreach ((int count, int level) in result)
        // {
        //     Console.WriteLine($"{count}, {level}");
        // }

        //BalnacedForest =======> still not resolve this problem
        //JennySubtrees
        int numOfNodesJenny = 7;
        int r = 1;
        int[][] edges_Jenny = new int[][]{
            new int[2]{1, 2},
            new int[2]{1, 3},
            new int[2]{1, 4},
            new int[2]{1, 5},
            new int[2]{2, 6},
            new int[2]{2, 7},
        };
        Graph_Jenny newGraphJennyTree = new Graph_Jenny(numOfNodesJenny);
        foreach (var edge in edges_Jenny)
        {
            newGraphJennyTree.AddEdge(edge);
        }
        Console.WriteLine("Graph Jenny Tree: ........");
        Console.WriteLine("Jenny tree result: " + newGraphJennyTree.JennySubtreesAlgorithm(r));

        //ArrayPairs
        //SelfBalancingTree
        Node_AVLTree rootAVL = new Node_AVLTree(3);
        AVLTree tree_AVL = new AVLTree(rootAVL);
        tree_AVL.AddNewNode(rootAVL, new Node_AVLTree(2));
        tree_AVL.AddNewNode(rootAVL, new Node_AVLTree(4));
        tree_AVL.AddNewNode(rootAVL, new Node_AVLTree(5));
        tree_AVL.AddNewNode(rootAVL, new Node_AVLTree(6));
        Console.WriteLine("AVL Tree: .....");
        tree_AVL.TranversTree(rootAVL);

        tree_AVL.balanceTree(rootAVL);
        Console.WriteLine("AVL Tree: .....");
        tree_AVL.TranversTree(rootAVL);






    }

    interface IPrintInt
    {
        void PrintArrInt(int[] arr);
    }

    interface IPrintString
    {
        void PrintArrString(string[] arr);
    }

    interface IPrint2DIntArr
    {
        void Print2DIntArr(int[,] arr, int n);
    }

    public class Print : IPrintInt, IPrintString, IPrint2DIntArr
    {
        public void PrintArrInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public void PrintArrString(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void Print2DIntArr(int[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
// test git stash



