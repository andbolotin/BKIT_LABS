//функция ввода числа с клавиатуры 
let rec readFloat() = 
    match System.Double.TryParse(System.Console.ReadLine()) with
    | false, _ -> printfn "Введите число"; readFloat()
    | _, x -> x
 
//ввод с клавиатуры коэффициентов уравнения
let a = readFloat();
let b = readFloat();
let c = readFloat();
 
//зададим тип - результат решения квадратного уравнения
type ResultOfSolve=
    None
    |Lin of float
    |Quadr of float*float
 
//зададим формулу решения квадратого уравнения в общем виде
let solution = fun (a,b,c) ->
    let D = b*b-4.0*a*c
    if a=0.0 then 
        if b=0.0 then None else Lin(-c/b)
    else
        if D<0.0 then None else Quadr(((-b+sqrt(D))/(2.0*a),(-b-sqrt(D))/(2.0*a))) 
 
//решим квадратное уравнение
let res = solution(a,b,c);
 
//выведем результат
match res with 
    None -> printf "Корней нет"
    |Lin(x) -> printf "Корень %f" x
    |Quadr(x1,x2) -> printf "Корни %f %f " x1 x2
 
System.Console.Read();
