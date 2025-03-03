//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/GitProjects/Righthand/C64/C64-Assembler-Studio/src/C64AssemblerStudio/C64AssemblerStudio.Engine/Grammars/AddressEntry/AddressEntryParser.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class AddressEntryParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		OPEN_PARENS=1, CLOSE_PARENS=2, PLUS=3, MINUS=4, STAR=5, DIV=6, DEC_NUMBER=7, 
		HEX_NUMBER=8, BIN_NUMBER=9, UNQUOTED_STRING=10, EOL=11, WS=12;
	public const int
		RULE_address = 0, RULE_arguments = 1, RULE_argument = 2;
	public static readonly string[] ruleNames = {
		"address", "arguments", "argument"
	};

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'+'", "'-'", "'*'", "'/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "OPEN_PARENS", "CLOSE_PARENS", "PLUS", "MINUS", "STAR", "DIV", "DEC_NUMBER", 
		"HEX_NUMBER", "BIN_NUMBER", "UNQUOTED_STRING", "EOL", "WS"
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

	public override string GrammarFileName { get { return "AddressEntryParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static AddressEntryParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public AddressEntryParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public AddressEntryParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class AddressContext : ParserRuleContext {
		public AddressContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_address; } }
	 
		public AddressContext() { }
		public virtual void CopyFrom(AddressContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class RootContext : AddressContext {
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments() {
			return GetRuleContext<ArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(AddressEntryParser.Eof, 0); }
		public RootContext(AddressContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterRoot(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitRoot(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRoot(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AddressContext address() {
		AddressContext _localctx = new AddressContext(Context, State);
		EnterRule(_localctx, 0, RULE_address);
		try {
			_localctx = new RootContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 6;
			arguments(0);
			State = 7;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArgumentsContext : ParserRuleContext {
		public ArgumentsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arguments; } }
	 
		public ArgumentsContext() { }
		public virtual void CopyFrom(ArgumentsContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class MultiplicationContext : ArgumentsContext {
		public ArgumentsContext left;
		public ArgumentsContext right;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(AddressEntryParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext[] arguments() {
			return GetRuleContexts<ArgumentsContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments(int i) {
			return GetRuleContext<ArgumentsContext>(i);
		}
		public MultiplicationContext(ArgumentsContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterMultiplication(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitMultiplication(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiplication(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParensContext : ArgumentsContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(AddressEntryParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments() {
			return GetRuleContext<ArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(AddressEntryParser.CLOSE_PARENS, 0); }
		public ParensContext(ArgumentsContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterParens(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitParens(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParens(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ArgContext : ArgumentsContext {
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentContext argument() {
			return GetRuleContext<ArgumentContext>(0);
		}
		public ArgContext(ArgumentsContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterArg(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitArg(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArg(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DivisionContext : ArgumentsContext {
		public ArgumentsContext left;
		public ArgumentsContext right;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV() { return GetToken(AddressEntryParser.DIV, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext[] arguments() {
			return GetRuleContexts<ArgumentsContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments(int i) {
			return GetRuleContext<ArgumentsContext>(i);
		}
		public DivisionContext(ArgumentsContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterDivision(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitDivision(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDivision(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PlusContext : ArgumentsContext {
		public ArgumentsContext left;
		public ArgumentsContext right;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUS() { return GetToken(AddressEntryParser.PLUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext[] arguments() {
			return GetRuleContexts<ArgumentsContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments(int i) {
			return GetRuleContext<ArgumentsContext>(i);
		}
		public PlusContext(ArgumentsContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterPlus(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitPlus(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPlus(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MinusContext : ArgumentsContext {
		public ArgumentsContext left;
		public ArgumentsContext right;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(AddressEntryParser.MINUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext[] arguments() {
			return GetRuleContexts<ArgumentsContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments(int i) {
			return GetRuleContext<ArgumentsContext>(i);
		}
		public MinusContext(ArgumentsContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterMinus(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitMinus(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMinus(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ArgumentsContext arguments() {
		return arguments(0);
	}

	private ArgumentsContext arguments(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ArgumentsContext _localctx = new ArgumentsContext(Context, _parentState);
		ArgumentsContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_arguments, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 15;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_PARENS:
				{
				_localctx = new ParensContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 10;
				Match(OPEN_PARENS);
				State = 11;
				arguments(0);
				State = 12;
				Match(CLOSE_PARENS);
				}
				break;
			case DEC_NUMBER:
			case HEX_NUMBER:
			case BIN_NUMBER:
			case UNQUOTED_STRING:
				{
				_localctx = new ArgContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 14;
				argument();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 31;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 29;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
					case 1:
						{
						_localctx = new MultiplicationContext(new ArgumentsContext(_parentctx, _parentState));
						((MultiplicationContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_arguments);
						State = 17;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 18;
						Match(STAR);
						State = 19;
						((MultiplicationContext)_localctx).right = arguments(6);
						}
						break;
					case 2:
						{
						_localctx = new DivisionContext(new ArgumentsContext(_parentctx, _parentState));
						((DivisionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_arguments);
						State = 20;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 21;
						Match(DIV);
						State = 22;
						((DivisionContext)_localctx).right = arguments(5);
						}
						break;
					case 3:
						{
						_localctx = new PlusContext(new ArgumentsContext(_parentctx, _parentState));
						((PlusContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_arguments);
						State = 23;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 24;
						Match(PLUS);
						State = 25;
						((PlusContext)_localctx).right = arguments(4);
						}
						break;
					case 4:
						{
						_localctx = new MinusContext(new ArgumentsContext(_parentctx, _parentState));
						((MinusContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_arguments);
						State = 26;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 27;
						Match(MINUS);
						State = 28;
						((MinusContext)_localctx).right = arguments(3);
						}
						break;
					}
					} 
				}
				State = 33;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ArgumentContext : ParserRuleContext {
		public ArgumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_argument; } }
	 
		public ArgumentContext() { }
		public virtual void CopyFrom(ArgumentContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DecNumberContext : ArgumentContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEC_NUMBER() { return GetToken(AddressEntryParser.DEC_NUMBER, 0); }
		public DecNumberContext(ArgumentContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterDecNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitDecNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDecNumber(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LabelContext : ArgumentContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNQUOTED_STRING() { return GetToken(AddressEntryParser.UNQUOTED_STRING, 0); }
		public LabelContext(ArgumentContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterLabel(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitLabel(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLabel(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class HexNumberContext : ArgumentContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HEX_NUMBER() { return GetToken(AddressEntryParser.HEX_NUMBER, 0); }
		public HexNumberContext(ArgumentContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterHexNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitHexNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHexNumber(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BinNumberContext : ArgumentContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BIN_NUMBER() { return GetToken(AddressEntryParser.BIN_NUMBER, 0); }
		public BinNumberContext(ArgumentContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.EnterBinNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAddressEntryParserListener typedListener = listener as IAddressEntryParserListener;
			if (typedListener != null) typedListener.ExitBinNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAddressEntryParserVisitor<TResult> typedVisitor = visitor as IAddressEntryParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBinNumber(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ArgumentContext argument() {
		ArgumentContext _localctx = new ArgumentContext(Context, State);
		EnterRule(_localctx, 4, RULE_argument);
		try {
			State = 38;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case UNQUOTED_STRING:
				_localctx = new LabelContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 34;
				Match(UNQUOTED_STRING);
				}
				break;
			case DEC_NUMBER:
				_localctx = new DecNumberContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 35;
				Match(DEC_NUMBER);
				}
				break;
			case HEX_NUMBER:
				_localctx = new HexNumberContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 36;
				Match(HEX_NUMBER);
				}
				break;
			case BIN_NUMBER:
				_localctx = new BinNumberContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 37;
				Match(BIN_NUMBER);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return arguments_sempred((ArgumentsContext)_localctx, predIndex);
		}
		return true;
	}
	private bool arguments_sempred(ArgumentsContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 5);
		case 1: return Precpred(Context, 4);
		case 2: return Precpred(Context, 3);
		case 3: return Precpred(Context, 2);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,12,41,2,0,7,0,2,1,7,1,2,2,7,2,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,
		3,1,16,8,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5,1,30,8,1,
		10,1,12,1,33,9,1,1,2,1,2,1,2,1,2,3,2,39,8,2,1,2,0,1,2,3,0,2,4,0,0,45,0,
		6,1,0,0,0,2,15,1,0,0,0,4,38,1,0,0,0,6,7,3,2,1,0,7,8,5,0,0,1,8,1,1,0,0,
		0,9,10,6,1,-1,0,10,11,5,1,0,0,11,12,3,2,1,0,12,13,5,2,0,0,13,16,1,0,0,
		0,14,16,3,4,2,0,15,9,1,0,0,0,15,14,1,0,0,0,16,31,1,0,0,0,17,18,10,5,0,
		0,18,19,5,5,0,0,19,30,3,2,1,6,20,21,10,4,0,0,21,22,5,6,0,0,22,30,3,2,1,
		5,23,24,10,3,0,0,24,25,5,3,0,0,25,30,3,2,1,4,26,27,10,2,0,0,27,28,5,4,
		0,0,28,30,3,2,1,3,29,17,1,0,0,0,29,20,1,0,0,0,29,23,1,0,0,0,29,26,1,0,
		0,0,30,33,1,0,0,0,31,29,1,0,0,0,31,32,1,0,0,0,32,3,1,0,0,0,33,31,1,0,0,
		0,34,39,5,10,0,0,35,39,5,7,0,0,36,39,5,8,0,0,37,39,5,9,0,0,38,34,1,0,0,
		0,38,35,1,0,0,0,38,36,1,0,0,0,38,37,1,0,0,0,39,5,1,0,0,0,4,15,29,31,38
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
