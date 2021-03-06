using System;

namespace ProgrammingLanguageNr1
{
	public class Token
	{
		public enum TokenType { 
			
			NO_TOKEN_TYPE, 
			EOF, 
            NEW_LINE, 
            COMMA,
			
            NAME, 
			ARRAY_LOOKUP,
            OPERATOR, 
            NUMBER, 
            QUOTED_STRING, 
			BOOLEAN_VALUE,
			ARRAY,
			
			ARRAY_END_SIGNAL,
            BUILT_IN_TYPE_NAME,
            ELSE, 
            PARANTHESIS_LEFT, 
            PARANTHESIS_RIGHT,
			BRACKET_LEFT,
			BRACKET_RIGHT,
			//BLOCK_BEGIN, 
            BLOCK_END, 			
            STATEMENT_LIST, 
			VAR_DECLARATION, 
            FUNC_DECLARATION,
			NODE_GROUP, 
            PARAMETER,
            FUNCTION_CALL,
            ASSIGNMENT,
			ASSIGNMENT_TO_ARRAY,
            IF,
            LOOP,
			LOOP_BLOCK,
			LOOP_INCREMENT,
			GOTO_BEGINNING_OF_LOOP,
            BREAK,
            RETURN,
            PROGRAM_ROOT,
            COMMENT,
			FROM,
			TO
		};
		
		public Token (TokenType tokenType, string tokenString)
		{
			m_tokenType = tokenType;
			m_tokenString = tokenString;
		}

        public Token(TokenType tokenType, string tokenString, int lineNr, int linePosition)
        {
            m_tokenType = tokenType;
            m_tokenString = tokenString;
            m_lineNr = lineNr;
            m_linePosition = linePosition;
        }
		
		public TokenType getTokenType() { return m_tokenType; }
		public string getTokenString() { return m_tokenString; }
		
		public int LineNr {
			set {
				m_lineNr = value;
			}
			get {
				return m_lineNr;
			}
		}
		
		public int LinePosition {
			set {
				m_linePosition = value;
			}
			get {
				return m_linePosition;
			}
		}
		
		protected TokenType m_tokenType;
		string m_tokenString;
		int m_lineNr = -1;
		int m_linePosition = -1;
	}
	
	public class TokenWithValue : Token {
		public TokenWithValue(TokenType tokenType, string tokenString, int lineNr, int linePosition, ReturnValue pValue)
			: base(tokenType, tokenString, lineNr, linePosition)
		{
			m_value = pValue;
		}		
		public TokenWithValue(TokenType pTokenType, string pTokenString, ReturnValue pValue) : base(pTokenType, pTokenString) {
			m_value = pValue;
		}
		public ReturnValue getValue() {
			return m_value;
		}
		private ReturnValue m_value;
	}
}

