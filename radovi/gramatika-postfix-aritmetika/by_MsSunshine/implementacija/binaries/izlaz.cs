// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2008
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.5.190
// Machine:  IVANAPC
// DateTime: 10.1.2010. 16:07:18
// UserName: ivana
// Input file <zadatak.y>

// options: lines

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;

public enum Tokens {error=48,
    EOF=49,DIGIT=50,UMINUS=51};

public class Parser: ShiftReduceParser<int, LexLocation>
{
#line 2 "zadatak.y"
    int[] regs = new int[26];
#line 3 "zadatak.y"
    int _base=10;
#pragma warning disable 649
    private Dictionary<int, string> aliasses;
#pragma warning restore 649

  protected override void Initialize()
  {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);

    this.InitStateTable(21);
    AddState(0,new State(-2,new int[]{-1,1}));
    AddState(1,new State(new int[]{49,2,48,5,42,8,47,11,43,14,45,17,50,20},new int[]{-3,3,-4,7,-5,19}));
    AddState(2,new State(-1));
    AddState(3,new State(new int[]{10,4}));
    AddState(4,new State(-3));
    AddState(5,new State(new int[]{10,6}));
    AddState(6,new State(-4));
    AddState(7,new State(-5));
    AddState(8,new State(new int[]{42,8,47,11,43,14,45,17,50,20},new int[]{-4,9,-5,19}));
    AddState(9,new State(new int[]{42,8,47,11,43,14,45,17,50,20},new int[]{-4,10,-5,19}));
    AddState(10,new State(-6));
    AddState(11,new State(new int[]{42,8,47,11,43,14,45,17,50,20},new int[]{-4,12,-5,19}));
    AddState(12,new State(new int[]{42,8,47,11,43,14,45,17,50,20},new int[]{-4,13,-5,19}));
    AddState(13,new State(-7));
    AddState(14,new State(new int[]{42,8,47,11,43,14,45,17,50,20},new int[]{-4,15,-5,19}));
    AddState(15,new State(new int[]{42,8,47,11,43,14,45,17,50,20},new int[]{-4,16,-5,19}));
    AddState(16,new State(-8));
    AddState(17,new State(new int[]{42,8,47,11,43,14,45,17,50,20},new int[]{-4,18,-5,19}));
    AddState(18,new State(-9));
    AddState(19,new State(-10));
    AddState(20,new State(-11));

    Rule[] rules=new Rule[12];
    rules[1]=new Rule(-2, new int[]{-1,49});
    rules[2]=new Rule(-1, new int[]{});
    rules[3]=new Rule(-1, new int[]{-1,-3,10});
    rules[4]=new Rule(-1, new int[]{-1,48,10});
    rules[5]=new Rule(-3, new int[]{-4});
    rules[6]=new Rule(-4, new int[]{42,-4,-4});
    rules[7]=new Rule(-4, new int[]{47,-4,-4});
    rules[8]=new Rule(-4, new int[]{43,-4,-4});
    rules[9]=new Rule(-4, new int[]{45,-4});
    rules[10]=new Rule(-4, new int[]{-5});
    rules[11]=new Rule(-5, new int[]{50});
    this.InitRules(rules);

    this.InitNonTerminals(new string[] {"", "list", "$accept", "stat", "expr", 
      "number", });
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 4: // list -> list, error, '\n'
#line 20 "zadatak.y"
{
#line 21 "zadatak.y"
                    yyerrok();
#line 22 "zadatak.y"
                }
        break;
      case 5: // stat -> expr
#line 26 "zadatak.y"
{
#line 27 "zadatak.y"
                    
#line 28 "zadatak.y"
                }
        break;
      case 6: // expr -> '*', expr, expr
#line 34 "zadatak.y"
{
#line 35 "zadatak.y"
			
#line 36 "zadatak.y"
			System.Console.WriteLine("MUL R"+(ValueStack[ValueStack.Depth-2]-10)+" , R"+(ValueStack[ValueStack.Depth-1]-10)+" , R"+(_base-10));
#line 37 "zadatak.y"
			
#line 38 "zadatak.y"
                    CurrentSemanticValue = _base++;
#line 39 "zadatak.y"
                }
        break;
      case 7: // expr -> '/', expr, expr
#line 41 "zadatak.y"
{
#line 42 "zadatak.y"
			
#line 43 "zadatak.y"
			System.Console.WriteLine("DIV R"+(ValueStack[ValueStack.Depth-2]-10)+" , R"+(ValueStack[ValueStack.Depth-1]-10)+" , R"+(_base-10));
#line 44 "zadatak.y"
			
#line 45 "zadatak.y"
                    CurrentSemanticValue = _base++;
#line 46 "zadatak.y"
                }
        break;
      case 8: // expr -> '+', expr, expr
#line 49 "zadatak.y"
{
#line 50 "zadatak.y"
			
#line 51 "zadatak.y"
		System.Console.WriteLine("ADD R"+(ValueStack[ValueStack.Depth-2]-10)+" , R"+(ValueStack[ValueStack.Depth-1]-10)+" , R"+(_base-10));
#line 52 "zadatak.y"
			
#line 53 "zadatak.y"
                    CurrentSemanticValue = _base++;
#line 54 "zadatak.y"
                }
        break;
      case 9: // expr -> '-', expr
#line 56 "zadatak.y"
{
#line 57 "zadatak.y"
			
#line 58 "zadatak.y"
			System.Console.WriteLine("SUB "+ 0 +" , R"+(ValueStack[ValueStack.Depth-1]-10)+" , R"+(_base-10));
#line 59 "zadatak.y"
			
#line 60 "zadatak.y"
                    CurrentSemanticValue = _base++;
#line 61 "zadatak.y"
                }
        break;
      case 11: // number -> DIGIT
#line 68 "zadatak.y"
{
#line 69 "zadatak.y"
			System.Console.WriteLine("MOVE "+ValueStack[ValueStack.Depth-1]+" R"+(_base-10));
#line 70 "zadatak.y"
			
#line 71 "zadatak.y"
                    CurrentSemanticValue = _base++;
#line 72 "zadatak.y"
                   
#line 73 "zadatak.y"
                }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 78 "zadatak.y"

#line 79 "zadatak.y"
    Parser() : base(null) { }
#line 80 "zadatak.y"

#line 81 "zadatak.y"
    static void Main(string[] args)
#line 82 "zadatak.y"
    {
#line 83 "zadatak.y"
        Parser parser = new Parser();
#line 84 "zadatak.y"
        
#line 85 "zadatak.y"
        System.IO.TextReader reader;
#line 86 "zadatak.y"
        if (args.Length > 0)
#line 87 "zadatak.y"
            reader = new System.IO.StreamReader(args[0]);
#line 88 "zadatak.y"
        else
#line 89 "zadatak.y"
            reader = System.Console.In;
#line 90 "zadatak.y"
            
#line 91 "zadatak.y"
        parser.Scanner = new Lexer(reader);
#line 92 "zadatak.y"
        //parser.Trace = true;
#line 93 "zadatak.y"
        
#line 94 "zadatak.y"
        parser.Parse();
#line 95 "zadatak.y"
    }
#line 96 "zadatak.y"

#line 97 "zadatak.y"

#line 98 "zadatak.y"
    /*
#line 99 "zadatak.y"
     * Copied from GPPG documentation.
#line 100 "zadatak.y"
     */
#line 101 "zadatak.y"
    class Lexer: QUT.Gppg.AbstractScanner<int,LexLocation>
#line 102 "zadatak.y"
    {
#line 103 "zadatak.y"
         private System.IO.TextReader reader;
#line 104 "zadatak.y"
    
#line 105 "zadatak.y"
         //
#line 106 "zadatak.y"
         // Version 1.2.0 needed the following code.
#line 107 "zadatak.y"
         // In V1.2.1 the base class provides this empty default.
#line 108 "zadatak.y"
         //
#line 109 "zadatak.y"
         // public override LexLocation yylloc { 
#line 110 "zadatak.y"
         //     get { return null; } 
#line 111 "zadatak.y"
         //     set { /* skip */; }
#line 112 "zadatak.y"
         // }
#line 113 "zadatak.y"
         //
#line 114 "zadatak.y"
    
#line 115 "zadatak.y"
         public Lexer(System.IO.TextReader reader)
#line 116 "zadatak.y"
         {
#line 117 "zadatak.y"
             this.reader = reader;
#line 118 "zadatak.y"
         }
#line 119 "zadatak.y"
    
#line 120 "zadatak.y"
         public override int yylex()
#line 121 "zadatak.y"
         {
#line 122 "zadatak.y"
             char ch;
#line 123 "zadatak.y"
             int ord = reader.Read();
#line 124 "zadatak.y"
             //
#line 125 "zadatak.y"
             // Must check for EOF
#line 126 "zadatak.y"
             //
#line 127 "zadatak.y"
             if (ord == -1)
#line 128 "zadatak.y"
                 return (int)Tokens.EOF;
#line 129 "zadatak.y"
             else
#line 130 "zadatak.y"
                 ch = (char)ord;
#line 131 "zadatak.y"
    
#line 132 "zadatak.y"
             if (ch == '\n')
#line 133 "zadatak.y"
                return ch;
#line 134 "zadatak.y"
             else if (char.IsWhiteSpace(ch))
#line 135 "zadatak.y"
                 return yylex();
#line 136 "zadatak.y"
             else if (char.IsDigit(ch))
#line 137 "zadatak.y"
             {
#line 138 "zadatak.y"
                 yylval = ch - '0';
#line 139 "zadatak.y"
                 return (int)Tokens.DIGIT;
#line 140 "zadatak.y"
             }
#line 141 "zadatak.y"
             
#line 142 "zadatak.y"
             else
#line 143 "zadatak.y"
                 switch (ch)
#line 144 "zadatak.y"
                 {
#line 145 "zadatak.y"
                     case '+':
#line 146 "zadatak.y"
                     case '-':
#line 147 "zadatak.y"
                     case '*':
#line 148 "zadatak.y"
                     case '/':
#line 149 "zadatak.y"
		     
#line 150 "zadatak.y"
                    
#line 151 "zadatak.y"
                         return ch;
#line 152 "zadatak.y"
                     default:
#line 153 "zadatak.y"
                         Console.Error.WriteLine("ovo ne smije biti u ulazu '{0}'", ch);
#line 154 "zadatak.y"
                         return yylex();
#line 155 "zadatak.y"
                 }
#line 156 "zadatak.y"
         }
#line 157 "zadatak.y"
    
#line 158 "zadatak.y"
         public override void yyerror(string format, params object[] args)
#line 159 "zadatak.y"
         {
#line 160 "zadatak.y"
             Console.Error.WriteLine(format, args);
#line 161 "zadatak.y"
         }
#line 162 "zadatak.y"
    }
}