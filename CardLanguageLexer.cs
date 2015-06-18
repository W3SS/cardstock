//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CardLanguage.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public partial class CardLanguageLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, T__48=49, T__49=50, T__50=51, T__51=52, 
		BOOLOP=53, COMPOP=54, EQOP=55, UNOP=56, INTNUM=57, OPEN=58, CLOSE=59, 
		WS=60, ANY=61;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "T__48", 
		"T__49", "T__50", "T__51", "BOOLOP", "COMPOP", "EQOP", "UNOP", "INTNUM", 
		"OPEN", "CLOSE", "WS", "ANY"
	};


	public CardLanguageLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'game'", "'stage'", "'player'", "'team'", "'end'", "'comp'", "'choice'", 
		"'create'", "'loc'", "'Stack'", "'List'", "'Queue'", "'Memory'", "'sto'", 
		"','", "'players'", "'teams'", "'alternate'", "'initialize'", "'sequential'", 
		"'permdeck'", "'points'", "'set'", "'next'", "'current'", "'inc'", "'dec'", 
		"'move'", "'all'", "'copy'", "'turn'", "'over'", "'pass'", "'remove'", 
		"'shuffle'", "'top'", "'bottom'", "'any'", "'owner'", "'where'", "'cardatt'", 
		"'this'", "'+'", "'*'", "'-'", "'%'", "'//'", "'size'", "'max'", "'using'", 
		"'union'", "'sum'", null, null, null, "'not'", null, "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, "BOOLOP", "COMPOP", "EQOP", "UNOP", "INTNUM", 
		"OPEN", "CLOSE", "WS", "ANY"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CardLanguage.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2?\x1C3\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32"+
		"\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37"+
		"\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x3\x2\x3"+
		"\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3"+
		"\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b"+
		"\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\r"+
		"\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF"+
		"\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11"+
		"\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13"+
		"\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14"+
		"\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15"+
		"\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16"+
		"\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17"+
		"\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19"+
		"\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A"+
		"\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D"+
		"\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F"+
		"\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 \x3!\x3!\x3!\x3!\x3!\x3\"\x3"+
		"\"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3$\x3$\x3$\x3$\x3$\x3$"+
		"\x3$\x3$\x3%\x3%\x3%\x3%\x3&\x3&\x3&\x3&\x3&\x3&\x3&\x3\'\x3\'\x3\'\x3"+
		"\'\x3(\x3(\x3(\x3(\x3(\x3(\x3)\x3)\x3)\x3)\x3)\x3)\x3*\x3*\x3*\x3*\x3"+
		"*\x3*\x3*\x3*\x3+\x3+\x3+\x3+\x3+\x3,\x3,\x3-\x3-\x3.\x3.\x3/\x3/\x3\x30"+
		"\x3\x30\x3\x30\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x32\x3\x32\x3\x32"+
		"\x3\x32\x3\x33\x3\x33\x3\x33\x3\x33\x3\x33\x3\x33\x3\x34\x3\x34\x3\x34"+
		"\x3\x34\x3\x34\x3\x34\x3\x35\x3\x35\x3\x35\x3\x35\x3\x36\x3\x36\x3\x36"+
		"\x3\x36\x3\x36\x5\x36\x1A2\n\x36\x3\x37\x3\x37\x3\x37\x3\x37\x3\x37\x5"+
		"\x37\x1A9\n\x37\x3\x38\x3\x38\x3\x38\x3\x38\x5\x38\x1AF\n\x38\x3\x39\x3"+
		"\x39\x3\x39\x3\x39\x3:\x3:\x3;\x3;\x3<\x3<\x3=\x6=\x1BC\n=\r=\xE=\x1BD"+
		"\x3=\x3=\x3>\x3>\x2\x2?\x3\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v"+
		"\x15\f\x17\r\x19\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+"+
		"\x17-\x18/\x19\x31\x1A\x33\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F= ?!\x41\""+
		"\x43#\x45$G%I&K\'M(O)Q*S+U,W-Y.[/]\x30_\x31\x61\x32\x63\x33\x65\x34g\x35"+
		"i\x36k\x37m\x38o\x39q:s;u<w=y>{?\x3\x2\x5\x4\x2>>@@\x3\x2\x32;\x5\x2\v"+
		"\f\xF\xF\"\"\x1C7\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2"+
		"\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2"+
		"\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2"+
		"\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F"+
		"\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2"+
		"\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2"+
		"\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2"+
		"\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2"+
		"\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2"+
		"\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2"+
		"\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3"+
		"\x2\x2\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2\x2\x61\x3\x2"+
		"\x2\x2\x2\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2\x2\x2g\x3\x2\x2\x2\x2i\x3\x2"+
		"\x2\x2\x2k\x3\x2\x2\x2\x2m\x3\x2\x2\x2\x2o\x3\x2\x2\x2\x2q\x3\x2\x2\x2"+
		"\x2s\x3\x2\x2\x2\x2u\x3\x2\x2\x2\x2w\x3\x2\x2\x2\x2y\x3\x2\x2\x2\x2{\x3"+
		"\x2\x2\x2\x3}\x3\x2\x2\x2\x5\x82\x3\x2\x2\x2\a\x88\x3\x2\x2\x2\t\x8F\x3"+
		"\x2\x2\x2\v\x94\x3\x2\x2\x2\r\x98\x3\x2\x2\x2\xF\x9D\x3\x2\x2\x2\x11\xA4"+
		"\x3\x2\x2\x2\x13\xAB\x3\x2\x2\x2\x15\xAF\x3\x2\x2\x2\x17\xB5\x3\x2\x2"+
		"\x2\x19\xBA\x3\x2\x2\x2\x1B\xC0\x3\x2\x2\x2\x1D\xC7\x3\x2\x2\x2\x1F\xCB"+
		"\x3\x2\x2\x2!\xCD\x3\x2\x2\x2#\xD5\x3\x2\x2\x2%\xDB\x3\x2\x2\x2\'\xE5"+
		"\x3\x2\x2\x2)\xF0\x3\x2\x2\x2+\xFB\x3\x2\x2\x2-\x104\x3\x2\x2\x2/\x10B"+
		"\x3\x2\x2\x2\x31\x10F\x3\x2\x2\x2\x33\x114\x3\x2\x2\x2\x35\x11C\x3\x2"+
		"\x2\x2\x37\x120\x3\x2\x2\x2\x39\x124\x3\x2\x2\x2;\x129\x3\x2\x2\x2=\x12D"+
		"\x3\x2\x2\x2?\x132\x3\x2\x2\x2\x41\x137\x3\x2\x2\x2\x43\x13C\x3\x2\x2"+
		"\x2\x45\x141\x3\x2\x2\x2G\x148\x3\x2\x2\x2I\x150\x3\x2\x2\x2K\x154\x3"+
		"\x2\x2\x2M\x15B\x3\x2\x2\x2O\x15F\x3\x2\x2\x2Q\x165\x3\x2\x2\x2S\x16B"+
		"\x3\x2\x2\x2U\x173\x3\x2\x2\x2W\x178\x3\x2\x2\x2Y\x17A\x3\x2\x2\x2[\x17C"+
		"\x3\x2\x2\x2]\x17E\x3\x2\x2\x2_\x180\x3\x2\x2\x2\x61\x183\x3\x2\x2\x2"+
		"\x63\x188\x3\x2\x2\x2\x65\x18C\x3\x2\x2\x2g\x192\x3\x2\x2\x2i\x198\x3"+
		"\x2\x2\x2k\x1A1\x3\x2\x2\x2m\x1A8\x3\x2\x2\x2o\x1AE\x3\x2\x2\x2q\x1B0"+
		"\x3\x2\x2\x2s\x1B4\x3\x2\x2\x2u\x1B6\x3\x2\x2\x2w\x1B8\x3\x2\x2\x2y\x1BB"+
		"\x3\x2\x2\x2{\x1C1\x3\x2\x2\x2}~\ai\x2\x2~\x7F\a\x63\x2\x2\x7F\x80\ao"+
		"\x2\x2\x80\x81\ag\x2\x2\x81\x4\x3\x2\x2\x2\x82\x83\au\x2\x2\x83\x84\a"+
		"v\x2\x2\x84\x85\a\x63\x2\x2\x85\x86\ai\x2\x2\x86\x87\ag\x2\x2\x87\x6\x3"+
		"\x2\x2\x2\x88\x89\ar\x2\x2\x89\x8A\an\x2\x2\x8A\x8B\a\x63\x2\x2\x8B\x8C"+
		"\a{\x2\x2\x8C\x8D\ag\x2\x2\x8D\x8E\at\x2\x2\x8E\b\x3\x2\x2\x2\x8F\x90"+
		"\av\x2\x2\x90\x91\ag\x2\x2\x91\x92\a\x63\x2\x2\x92\x93\ao\x2\x2\x93\n"+
		"\x3\x2\x2\x2\x94\x95\ag\x2\x2\x95\x96\ap\x2\x2\x96\x97\a\x66\x2\x2\x97"+
		"\f\x3\x2\x2\x2\x98\x99\a\x65\x2\x2\x99\x9A\aq\x2\x2\x9A\x9B\ao\x2\x2\x9B"+
		"\x9C\ar\x2\x2\x9C\xE\x3\x2\x2\x2\x9D\x9E\a\x65\x2\x2\x9E\x9F\aj\x2\x2"+
		"\x9F\xA0\aq\x2\x2\xA0\xA1\ak\x2\x2\xA1\xA2\a\x65\x2\x2\xA2\xA3\ag\x2\x2"+
		"\xA3\x10\x3\x2\x2\x2\xA4\xA5\a\x65\x2\x2\xA5\xA6\at\x2\x2\xA6\xA7\ag\x2"+
		"\x2\xA7\xA8\a\x63\x2\x2\xA8\xA9\av\x2\x2\xA9\xAA\ag\x2\x2\xAA\x12\x3\x2"+
		"\x2\x2\xAB\xAC\an\x2\x2\xAC\xAD\aq\x2\x2\xAD\xAE\a\x65\x2\x2\xAE\x14\x3"+
		"\x2\x2\x2\xAF\xB0\aU\x2\x2\xB0\xB1\av\x2\x2\xB1\xB2\a\x63\x2\x2\xB2\xB3"+
		"\a\x65\x2\x2\xB3\xB4\am\x2\x2\xB4\x16\x3\x2\x2\x2\xB5\xB6\aN\x2\x2\xB6"+
		"\xB7\ak\x2\x2\xB7\xB8\au\x2\x2\xB8\xB9\av\x2\x2\xB9\x18\x3\x2\x2\x2\xBA"+
		"\xBB\aS\x2\x2\xBB\xBC\aw\x2\x2\xBC\xBD\ag\x2\x2\xBD\xBE\aw\x2\x2\xBE\xBF"+
		"\ag\x2\x2\xBF\x1A\x3\x2\x2\x2\xC0\xC1\aO\x2\x2\xC1\xC2\ag\x2\x2\xC2\xC3"+
		"\ao\x2\x2\xC3\xC4\aq\x2\x2\xC4\xC5\at\x2\x2\xC5\xC6\a{\x2\x2\xC6\x1C\x3"+
		"\x2\x2\x2\xC7\xC8\au\x2\x2\xC8\xC9\av\x2\x2\xC9\xCA\aq\x2\x2\xCA\x1E\x3"+
		"\x2\x2\x2\xCB\xCC\a.\x2\x2\xCC \x3\x2\x2\x2\xCD\xCE\ar\x2\x2\xCE\xCF\a"+
		"n\x2\x2\xCF\xD0\a\x63\x2\x2\xD0\xD1\a{\x2\x2\xD1\xD2\ag\x2\x2\xD2\xD3"+
		"\at\x2\x2\xD3\xD4\au\x2\x2\xD4\"\x3\x2\x2\x2\xD5\xD6\av\x2\x2\xD6\xD7"+
		"\ag\x2\x2\xD7\xD8\a\x63\x2\x2\xD8\xD9\ao\x2\x2\xD9\xDA\au\x2\x2\xDA$\x3"+
		"\x2\x2\x2\xDB\xDC\a\x63\x2\x2\xDC\xDD\an\x2\x2\xDD\xDE\av\x2\x2\xDE\xDF"+
		"\ag\x2\x2\xDF\xE0\at\x2\x2\xE0\xE1\ap\x2\x2\xE1\xE2\a\x63\x2\x2\xE2\xE3"+
		"\av\x2\x2\xE3\xE4\ag\x2\x2\xE4&\x3\x2\x2\x2\xE5\xE6\ak\x2\x2\xE6\xE7\a"+
		"p\x2\x2\xE7\xE8\ak\x2\x2\xE8\xE9\av\x2\x2\xE9\xEA\ak\x2\x2\xEA\xEB\a\x63"+
		"\x2\x2\xEB\xEC\an\x2\x2\xEC\xED\ak\x2\x2\xED\xEE\a|\x2\x2\xEE\xEF\ag\x2"+
		"\x2\xEF(\x3\x2\x2\x2\xF0\xF1\au\x2\x2\xF1\xF2\ag\x2\x2\xF2\xF3\as\x2\x2"+
		"\xF3\xF4\aw\x2\x2\xF4\xF5\ag\x2\x2\xF5\xF6\ap\x2\x2\xF6\xF7\av\x2\x2\xF7"+
		"\xF8\ak\x2\x2\xF8\xF9\a\x63\x2\x2\xF9\xFA\an\x2\x2\xFA*\x3\x2\x2\x2\xFB"+
		"\xFC\ar\x2\x2\xFC\xFD\ag\x2\x2\xFD\xFE\at\x2\x2\xFE\xFF\ao\x2\x2\xFF\x100"+
		"\a\x66\x2\x2\x100\x101\ag\x2\x2\x101\x102\a\x65\x2\x2\x102\x103\am\x2"+
		"\x2\x103,\x3\x2\x2\x2\x104\x105\ar\x2\x2\x105\x106\aq\x2\x2\x106\x107"+
		"\ak\x2\x2\x107\x108\ap\x2\x2\x108\x109\av\x2\x2\x109\x10A\au\x2\x2\x10A"+
		".\x3\x2\x2\x2\x10B\x10C\au\x2\x2\x10C\x10D\ag\x2\x2\x10D\x10E\av\x2\x2"+
		"\x10E\x30\x3\x2\x2\x2\x10F\x110\ap\x2\x2\x110\x111\ag\x2\x2\x111\x112"+
		"\az\x2\x2\x112\x113\av\x2\x2\x113\x32\x3\x2\x2\x2\x114\x115\a\x65\x2\x2"+
		"\x115\x116\aw\x2\x2\x116\x117\at\x2\x2\x117\x118\at\x2\x2\x118\x119\a"+
		"g\x2\x2\x119\x11A\ap\x2\x2\x11A\x11B\av\x2\x2\x11B\x34\x3\x2\x2\x2\x11C"+
		"\x11D\ak\x2\x2\x11D\x11E\ap\x2\x2\x11E\x11F\a\x65\x2\x2\x11F\x36\x3\x2"+
		"\x2\x2\x120\x121\a\x66\x2\x2\x121\x122\ag\x2\x2\x122\x123\a\x65\x2\x2"+
		"\x123\x38\x3\x2\x2\x2\x124\x125\ao\x2\x2\x125\x126\aq\x2\x2\x126\x127"+
		"\ax\x2\x2\x127\x128\ag\x2\x2\x128:\x3\x2\x2\x2\x129\x12A\a\x63\x2\x2\x12A"+
		"\x12B\an\x2\x2\x12B\x12C\an\x2\x2\x12C<\x3\x2\x2\x2\x12D\x12E\a\x65\x2"+
		"\x2\x12E\x12F\aq\x2\x2\x12F\x130\ar\x2\x2\x130\x131\a{\x2\x2\x131>\x3"+
		"\x2\x2\x2\x132\x133\av\x2\x2\x133\x134\aw\x2\x2\x134\x135\at\x2\x2\x135"+
		"\x136\ap\x2\x2\x136@\x3\x2\x2\x2\x137\x138\aq\x2\x2\x138\x139\ax\x2\x2"+
		"\x139\x13A\ag\x2\x2\x13A\x13B\at\x2\x2\x13B\x42\x3\x2\x2\x2\x13C\x13D"+
		"\ar\x2\x2\x13D\x13E\a\x63\x2\x2\x13E\x13F\au\x2\x2\x13F\x140\au\x2\x2"+
		"\x140\x44\x3\x2\x2\x2\x141\x142\at\x2\x2\x142\x143\ag\x2\x2\x143\x144"+
		"\ao\x2\x2\x144\x145\aq\x2\x2\x145\x146\ax\x2\x2\x146\x147\ag\x2\x2\x147"+
		"\x46\x3\x2\x2\x2\x148\x149\au\x2\x2\x149\x14A\aj\x2\x2\x14A\x14B\aw\x2"+
		"\x2\x14B\x14C\ah\x2\x2\x14C\x14D\ah\x2\x2\x14D\x14E\an\x2\x2\x14E\x14F"+
		"\ag\x2\x2\x14FH\x3\x2\x2\x2\x150\x151\av\x2\x2\x151\x152\aq\x2\x2\x152"+
		"\x153\ar\x2\x2\x153J\x3\x2\x2\x2\x154\x155\a\x64\x2\x2\x155\x156\aq\x2"+
		"\x2\x156\x157\av\x2\x2\x157\x158\av\x2\x2\x158\x159\aq\x2\x2\x159\x15A"+
		"\ao\x2\x2\x15AL\x3\x2\x2\x2\x15B\x15C\a\x63\x2\x2\x15C\x15D\ap\x2\x2\x15D"+
		"\x15E\a{\x2\x2\x15EN\x3\x2\x2\x2\x15F\x160\aq\x2\x2\x160\x161\ay\x2\x2"+
		"\x161\x162\ap\x2\x2\x162\x163\ag\x2\x2\x163\x164\at\x2\x2\x164P\x3\x2"+
		"\x2\x2\x165\x166\ay\x2\x2\x166\x167\aj\x2\x2\x167\x168\ag\x2\x2\x168\x169"+
		"\at\x2\x2\x169\x16A\ag\x2\x2\x16AR\x3\x2\x2\x2\x16B\x16C\a\x65\x2\x2\x16C"+
		"\x16D\a\x63\x2\x2\x16D\x16E\at\x2\x2\x16E\x16F\a\x66\x2\x2\x16F\x170\a"+
		"\x63\x2\x2\x170\x171\av\x2\x2\x171\x172\av\x2\x2\x172T\x3\x2\x2\x2\x173"+
		"\x174\av\x2\x2\x174\x175\aj\x2\x2\x175\x176\ak\x2\x2\x176\x177\au\x2\x2"+
		"\x177V\x3\x2\x2\x2\x178\x179\a-\x2\x2\x179X\x3\x2\x2\x2\x17A\x17B\a,\x2"+
		"\x2\x17BZ\x3\x2\x2\x2\x17C\x17D\a/\x2\x2\x17D\\\x3\x2\x2\x2\x17E\x17F"+
		"\a\'\x2\x2\x17F^\x3\x2\x2\x2\x180\x181\a\x31\x2\x2\x181\x182\a\x31\x2"+
		"\x2\x182`\x3\x2\x2\x2\x183\x184\au\x2\x2\x184\x185\ak\x2\x2\x185\x186"+
		"\a|\x2\x2\x186\x187\ag\x2\x2\x187\x62\x3\x2\x2\x2\x188\x189\ao\x2\x2\x189"+
		"\x18A\a\x63\x2\x2\x18A\x18B\az\x2\x2\x18B\x64\x3\x2\x2\x2\x18C\x18D\a"+
		"w\x2\x2\x18D\x18E\au\x2\x2\x18E\x18F\ak\x2\x2\x18F\x190\ap\x2\x2\x190"+
		"\x191\ai\x2\x2\x191\x66\x3\x2\x2\x2\x192\x193\aw\x2\x2\x193\x194\ap\x2"+
		"\x2\x194\x195\ak\x2\x2\x195\x196\aq\x2\x2\x196\x197\ap\x2\x2\x197h\x3"+
		"\x2\x2\x2\x198\x199\au\x2\x2\x199\x19A\aw\x2\x2\x19A\x19B\ao\x2\x2\x19B"+
		"j\x3\x2\x2\x2\x19C\x19D\a\x63\x2\x2\x19D\x19E\ap\x2\x2\x19E\x1A2\a\x66"+
		"\x2\x2\x19F\x1A0\aq\x2\x2\x1A0\x1A2\at\x2\x2\x1A1\x19C\x3\x2\x2\x2\x1A1"+
		"\x19F\x3\x2\x2\x2\x1A2l\x3\x2\x2\x2\x1A3\x1A9\t\x2\x2\x2\x1A4\x1A5\a@"+
		"\x2\x2\x1A5\x1A9\a?\x2\x2\x1A6\x1A7\a>\x2\x2\x1A7\x1A9\a?\x2\x2\x1A8\x1A3"+
		"\x3\x2\x2\x2\x1A8\x1A4\x3\x2\x2\x2\x1A8\x1A6\x3\x2\x2\x2\x1A9n\x3\x2\x2"+
		"\x2\x1AA\x1AB\a#\x2\x2\x1AB\x1AF\a?\x2\x2\x1AC\x1AD\a?\x2\x2\x1AD\x1AF"+
		"\a?\x2\x2\x1AE\x1AA\x3\x2\x2\x2\x1AE\x1AC\x3\x2\x2\x2\x1AFp\x3\x2\x2\x2"+
		"\x1B0\x1B1\ap\x2\x2\x1B1\x1B2\aq\x2\x2\x1B2\x1B3\av\x2\x2\x1B3r\x3\x2"+
		"\x2\x2\x1B4\x1B5\t\x3\x2\x2\x1B5t\x3\x2\x2\x2\x1B6\x1B7\a*\x2\x2\x1B7"+
		"v\x3\x2\x2\x2\x1B8\x1B9\a+\x2\x2\x1B9x\x3\x2\x2\x2\x1BA\x1BC\t\x4\x2\x2"+
		"\x1BB\x1BA\x3\x2\x2\x2\x1BC\x1BD\x3\x2\x2\x2\x1BD\x1BB\x3\x2\x2\x2\x1BD"+
		"\x1BE\x3\x2\x2\x2\x1BE\x1BF\x3\x2\x2\x2\x1BF\x1C0\b=\x2\x2\x1C0z\x3\x2"+
		"\x2\x2\x1C1\x1C2\v\x2\x2\x2\x1C2|\x3\x2\x2\x2\a\x2\x1A1\x1A8\x1AE\x1BD"+
		"\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
