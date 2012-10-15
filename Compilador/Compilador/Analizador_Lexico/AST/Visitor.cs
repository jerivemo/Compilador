using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Compilador.Analizador_Lexico.AST;

namespace Compilador.Analizador_Lexico.AST
{
    public interface Visitor
    {

 Object VisitProgramSinNAdaAST();

 Object VisitProgramSinMetAST(programSinMetAST decls,Object arg);

 Object VisitProgramSinDeclAST(programSinDeclAST met,Object arg);

 Object VisitProgramConTodoAST(programConTodoAST todo, Object arg);

 Object VisitUnDeclAST(undeclAST unde, Object arg);

 Object VisitVarDeclAST(varDeclAST var, Object arg);

 Object VisitParseConsDeclAST(constDeclAST var, Object arg);

 Object VisitParseblockSinStatementAST(blockSinStatementAST b, Object arg);

 Object VisitBreakStatementAST(breakStatementAST b,object arg);

 Object VisitClassConVarDeclAST ( classConVarDeclAST var,object arg);

 Object VisitClassSinVarDeclAST (classSinVarDeclAST  var,object arg);

 Object VisitComaStatementAST (comaStatementAST  var,object arg);

 Object VisitCondFactAST ( condFactAST var,object arg);

 Object VisitConditionAST (conditionAST  var,object arg);

 Object VisitCondTermAS (condTermAST  var,object arg);

 Object VisiConstDeclAST (constDeclAST  var,object arg);

 Object VisitDesignatorAS (designatorAST var,object arg);

 Object VisitDesignatorConIdentExprAST ( designatorConIdentExprAST  var,object arg);

 Object VisitDesignatorSinIdentExprAST ( designatorSinIdentExprAST var,object arg);

 Object VisitDesignatorStatementActParsAST (designatorStatementActParsAST  var,object arg);

 Object VisitDesignatorStatementAsignacionAST (designatorStatementAsignacionAST  var,object arg);

Object VisitDesignatorStatementAST (designatorStatementAST  var,object arg);

 Object VisitDesignatorStatementAumentoAST (designatorStatementAumentoAST  var,object arg);

 Object VisitDesignatorStatementDecrementoAST(designatorStatementDecrementoAST var, object arg);

 Object VisitDesignatorStatementSinActParsAST(designatorStatementSinActParsAST var, object arg);

 Object VisitDesignatorStatementUnActParsAST(designatorStatementUnActParsAST var, object arg);

 Object VisitExprAddopTermAST(exprAddopTermAST var, object arg);

 Object VisitExpreSoloTermAST(expreSoloTermAST var, object arg);

 Object VisitExprNegativaAddopTermAST(exprNegativaAddopTermAST var, object arg);

 Object VisitExprNegativaTermAST(exprNegativaTermAST var, object arg);

 Object VisitFactorBoolAST(factorBoolAST var, object arg);

 Object VisitFactorCharConstAST(factorCharConstAST var, object arg);

 Object VisitFactorDesignatorAST(factorDesignatorAST var, object arg);

 Object VisitFactorDesignatorConActParsAST(factorDesignatorConActParsAST var, object arg);

 Object VisitFactorDesignatorSinActParsAST(factorDesignatorSinActParsAST var, object arg);

 Object VisitFactorExprAST(factorExprAST var, object arg);

 Object VisitFactorNewConExprAST(factorNewConExprAST var, object arg);
 Object VisitfactorNewSinExprAST(factorNewSinExprAST var, object arg);

 Object VisitFactorNumberAST(factorNumberAST var, object arg);

 Object VisitFormParsAST(formParsAST var, object arg);

 Object VisitForStatementAST(forStatementAST var, object arg);

 Object VisitForStatementConCondFuntAST(forStatementConCondFuntAST var, object arg);

 Object VisitForStatementConConditionAST(forStatementConConditionAST var, object arg);

 Object VisitForStatementConFuntionAST(forStatementConFuntionAST var, object arg);

 Object VisitForStatementSoloDeclAST(forStatementSoloDeclAST var, object arg);
 Object VisitIfStatementAST(ifStatementAST var, object arg);

 Object VisitIfStatementConELseAS(ifStatementConELseAST var, object arg);

 Object VisitIfStatementSinELseAST(ifStatementSinELseAST var, object arg);

 Object VisitMethodTipoConFormDeclsAST(methodTipoConFormDeclsAST var, object arg);
 Object VisitMethodTipoSinFormDeclsAST(methodTipoSinFormDeclsAST var, object arg);

 Object VisitMethodTipoSinFormParsAST(methodTipoSinFormParsAST var, object arg);

 Object VisitMethodTipoSinVarDeclAST(methodTipoSinVarDeclAST var, object arg);

 Object VisitMethodVoidConFormDeclsAST(methodVoidConFormDeclsAST var, object arg);
 Object VisitMethodVoidSinFormDeclsAST(methodVoidSinFormDeclsAST var, object arg);

 Object VisitMethodVoidSinFormParsAST(methodVoidSinFormParsAST var, object arg);

 Object VisitMethodVoidSinVarDeclAST(methodVoidSinVarDeclAST var, object arg);

 Object VisitMulopAST(mulopAST var, object arg);

// Object VisitProgramConTodoAST(programConTodoAST var, object arg);

 //Object VisitProgramSinDeclAST(programSinDeclAST var, object arg);

// Object VisitProgramSinMetAST(programSinMetAST var, object arg);

 Object VisitProgramSinNadaAST(programSinNadaAST var, object arg);

 Object VisitReadStatementAST(readStatementAST var, object arg);

 Object VisitRelopAST(relopAST var, object arg);

 Object VisitReturnStatementConExprAST(returnStatementConExprAST var, object arg);

 Object VisitReturnStatementSinExprAST(returnStatementSinExprAST var, object arg);

 Object VisitTermConMulopFactorAST(termConMulopFactorAST var, object arg);

 Object VisitTermSinMulopFactorAST(termSinMulopFactorAST var, object arg);

 Object VisitTypeConCorchetesAST(typeConCorchetesAST var, object arg);

 Object VisitTypeSinConCorchetesAST(typeSinConCorchetesAST var, object arg);

 Object VisitUnAddopTermAST(unAddopTermAST var, object arg);

 Object VisitUnCondFactAST(unCondFactAST var, object arg);

 Object VisitUnCondTermAST(unCondTermAST var, object arg);

 Object VisitUndeclAST(undeclAST var, object arg);

 Object VisitUnExprAST(unExprAST var, object arg);

 Object VisitUnIdentAST(unIdentAST var, object arg);

 Object VisitUnIdentExpreConExprAST(unIdentExpreConExprAST var, object arg);

 Object VisitUnIdentExpreConIdentAST(unIdentExpreConIdentAST var, object arg);

 Object VisitUnMulopTermAST(unMulopTermAST var, object arg);

 Object VisitUnStatementAST(unStatementAST var, object arg);

 Object VisitUnTipoIdentAST(unTipoIdentAST var, object arg);

 Object VisitVarAddopTermAST(varAddopTermAST var, object arg);

 Object VisitVarCondFactAST(varCondFactAST var, object arg);

 Object VisitVarCondTermAST(varCondTermAST var, object arg);

 //Object VisitVarDeclAST(varDeclAST var, object arg);

 Object VisitVarExprAST(varExprAST var, object arg);

 Object VisitVarIdentAST(varIdentAST var, object arg);

 Object VisitVarIdentExpreAST(varIdentExpreAST var, object arg);

 Object VisitVarMulopTermAST(varMulopTermAST var, object arg);

 Object VisitVarsdeclAST(varsdeclAST var, object arg);

 Object VisitVarStatementAST(varStatementAST var, object arg);

 Object VisitVarTipoIdentAST(varTipoIdentAST var, object arg);

 Object VisitWhileStatementAST(whileStatementAST var, object arg);

 Object VisitWriteStatementConNumAST(writeStatementConNumAST var, object arg);

 Object VisitWriteStatementSinNumAST(writeStatementSinNumAST var, object arg);

    }
}
