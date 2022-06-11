using System.Collections;
//Definicion e inicilizacion del diccionario
Dictionary<string, int> dep = new Dictionary<string, int>()
{
    {"Boaco",185013},
    {"Carazo",197139},
    {"Chinandega",439906},
    {"Chontales",190863},
    {"Costa Caribe Norte",530586},
    {"Costa Caribe Sur",414543},
    {"Estelí",229866},
    {"Granada",214317},
    {"Jinotega",475630},
    {"León",421050},
    {"Madriz",174744},
    {"Managua",1,575,819 },
    {"Masaya",391903},
    {"Matagalpa",593503},
    {"Nueva Segovia",271581},
    {"Río San Juan",135446},
    {"Rivas",182645}
};
//Ordenando de manera ascendente
int maxDep = dep.Values.ToArray().Max();
int minDep = dep.Values.ToArray().Min();
string maxDepkey = "", minDepkey = "";
//Mostrar el diccionario ordenado por poblacion 
foreach (var item in dep.Keys)




Console.WriteLine($"Mas pequeño:{orderDepResult.First().Key}");
Console.WriteLine($"Mas grande:{orderDepResult.Last().Key}");
//Suma de toda la poblacion
{
    if (dep[item] == maxDep)
        maxDepkey = item;
    if (dep[item] == minDep)
        minDepkey = item;
    if (minDepkey != "" && maxDepkey != "")
        break;
}

var orderDepResult=dep.OrderBy(d=>d.Value);


foreach (var item in orderDepResult)
    Console.WriteLine($"{item.Key,20} ==> {item.Value,10:N0}");

Console.WriteLine($"Población General:{dep.Values.Sum():N0}");
//Mayor y menor poblacion
Console.WriteLine($"Departamento con mayor Población:{maxDepkey}");
Console.WriteLine($"Departamento con menor Población:{minDepkey}");
