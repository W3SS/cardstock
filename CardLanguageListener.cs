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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CardLanguageParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public interface ICardLanguageListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.gameaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGameaction([NotNull] CardLanguageParser.GameactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.gameaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGameaction([NotNull] CardLanguageParser.GameactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAction([NotNull] CardLanguageParser.ActionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAction([NotNull] CardLanguageParser.ActionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.setaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetaction([NotNull] CardLanguageParser.SetactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.setaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetaction([NotNull] CardLanguageParser.SetactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.moveaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMoveaction([NotNull] CardLanguageParser.MoveactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.moveaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMoveaction([NotNull] CardLanguageParser.MoveactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.card"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCard([NotNull] CardLanguageParser.CardContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.card"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCard([NotNull] CardLanguageParser.CardContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.rawstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRawstorage([NotNull] CardLanguageParser.RawstorageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.rawstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRawstorage([NotNull] CardLanguageParser.RawstorageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.locstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocstorage([NotNull] CardLanguageParser.LocstorageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.locstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocstorage([NotNull] CardLanguageParser.LocstorageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] CardLanguageParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] CardLanguageParser.NameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.quantifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuantifier([NotNull] CardLanguageParser.QuantifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.quantifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuantifier([NotNull] CardLanguageParser.QuantifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolean([NotNull] CardLanguageParser.BooleanContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolean([NotNull] CardLanguageParser.BooleanContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.intOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntOp([NotNull] CardLanguageParser.IntOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.intOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntOp([NotNull] CardLanguageParser.IntOpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] CardLanguageParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] CardLanguageParser.IntContext context);
}
