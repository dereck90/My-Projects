package numberanalyzer;
//Programa para analizar la validez de la sintaxis de una expression
//Integrantes del grupo:Dereck Talavera gerena y Rene Soto Rodriguez

import java.util.Scanner;

class Expression {
//Integrantes del grupo:Dereck Talavera Gerena y Rene Soto Rodriguez

    String operation = "";

    public Expression() {

    }

    void setString(String s) {
        operation = s;
    }

    String getString() {
        return operation;
    }

    static boolean isValid(String expression) {
        int index = 0;
        String lft = "", rgt = "";
        
        //verifica si el string empieza con un  operador, si termina con un operador,
        //si hay 2 operadores seguidos o si termina con un punto y si una de ellas
        //se cumple, la expresion no es valida.
        if ((NumberAnalyzer.isOperator(expression.charAt(0)) == true)
                || (NumberAnalyzer.isOperator(expression.charAt(expression.length() - 1)) == true)
                || (NumberAnalyzer.isOperatorDuplicate(expression, 0) == true)
                || (expression.endsWith("."))) {
            return false;
        } else {
            while ((index < expression.length() && (NumberAnalyzer.isOperator(expression.charAt(index))) == false)) {
                index++;
            }
            //Se parte el string en 2 partes en donde esta el operador, o sea 
            //se guarda el string antes del operador y el que esta despues.
            if (NumberAnalyzer.isOperator(expression.charAt(index - 1)) == true) {
                lft = expression.substring(0, index);
                rgt = expression.substring(index + 1);
            } else {
                lft = expression.substring(0, index);
            }
        }
        //Se envia el string de la izquierda y el de la derecha a verificar si es
        //un numero.
        return ((NumberAnalyzer.isNumber(lft)
                || (NumberAnalyzer.isNumber(lft) && NumberAnalyzer.isNumber(rgt))
                || (NumberAnalyzer.isNumber(lft) && isValid(rgt))));
    }

}

public class NumberAnalyzer {

    static boolean isDigit(char c) {
        if ((c == '1')
                || (c == '2')
                || (c == '3')
                || (c == '4')
                || (c == '5')
                || (c == '6')
                || (c == '7')
                || (c == '8')
                || (c == '9')
                || (c == '0')) {
            return (true);
        } else {
            return (false);
        }
    }

    static boolean isOperator(char c) {
        if ((c == '+')
                || (c == '-')
                || (c == '*')
                || (c == '/')) {
            return (true);
        } else {
            return (false);
        }
    }

    static boolean isInteger(String expression) {
        String rightSide;

        if (expression.length() == 1) {
            //Solo si el carater retorna si es un
            //digito si o no
            return (isDigit(expression.charAt(0)));
        } else {
            //Si hay dos o mas caracteres verifica primero si uno de ellos es un digito
            //y los demas son enteros
            //Metodo substring retorna todos los caracteres desde
            //el principio del indice, hasta, pero sin incluir, el indice final

            rightSide = expression.substring(1, expression.length());
            return ((isDigit(expression.charAt(0)))
                    && (isInteger(rightSide)));
        }
    }

    static boolean isDecimal(String expression) {
        int dotPosition;
        String leftSide,
                rightSide;
        dotPosition = expression.indexOf('.');

        //Si hay un punto en el string (el indice = -1) o si esta
        //en el comienzo o el final del string entonces no es
        //un numero decimal
        if ((dotPosition == -1) || (dotPosition == 0)
                || (dotPosition == expression.length() - 1)) {
            return (false);
        } else {
            //Si hay un punto en el string y ambos, el string
            //a su izquierda y a su derecha son enteros, entonces si es valida la expresion

            leftSide = expression.substring(0, dotPosition);
            rightSide = expression.substring(dotPosition + 1,
                    expression.length());
            return (isInteger(leftSide) && isInteger(rightSide));
        }
    }

    static boolean isNumber(String expression) {
        return (isDecimal(expression) || isInteger(expression));
    }

    static boolean isOperatorDuplicate(String expression, int index) {
        if (index < 1) {
            if (isOperator(expression.charAt(0)) == true && (isOperator(expression.charAt(1)) == true)) {
                return true;
            } else {
                index++;
            }
            //Si existe solo un operador entre medio de dos caracters la expresion es valida
            //Si por lo contrario existen dos o mas operadores repetidos consecutivos, la expresion no es valida

        } else if (index < expression.length()) {
            if (isOperator(expression.charAt(index)) == true && (isOperator(expression.charAt(++index)) == true)) {
                return true;
            } else {
                index++;
            }
        } else {
            return false;
        }
        return (isOperatorDuplicate(expression, index));
    }

    public static void main(String args[]) {
        Scanner input = new Scanner(System.in);
        Expression expression = new Expression();

        while (!expression.getString().equals("FIN")) {
            System.out.print("Enter the expression : ");
            expression.setString(input.next());

            if ((expression.isValid(expression.getString())) == true) {
                System.out.println("Valid Expression");
            } else {
                System.out.println("Invalid Expression");
            }
        }
    }
}
