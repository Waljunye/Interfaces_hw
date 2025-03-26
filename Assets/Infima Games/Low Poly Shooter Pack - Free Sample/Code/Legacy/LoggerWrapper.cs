using System.Collections;
using System.Collections.Generic;
using System.Linq;
using InfimaGames.LowPolyShooterPack;
using UnityEngine;

public class UnityLogger
{
    public void Log(string message)
    {
        Debug.Log(message);
    }
	
    public void LogCollection(IEnumerable<string> strs)
    {
        foreach (string str in strs)
        {
            Log(str);
        }
		if(strs is IList<string> lst) lst[0] = "Ya izmenil massiv";
    }

    public void LogMovable(IEnumerable<IMovable> movables)
    {
        foreach (var movable in movables)
        {
            Log($"{movable.name}: InputMovement:{movable.GetInputMovement()}");
        }
    }
}

public class LoggerWrapper : MonoBehaviour
{
    private UnityLogger logger = new();

    public UnityLogger Logger => logger;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //
            List<string> stringsList = new List<string>() { "STR", "StringTwo", "StringThree" };
            string[] stringsArray = new string[] { "STRARR", "StringArrTwo" };
            IEnumerable<string> onlyUpperCase = stringsList.Where(str => str.All(ch => char.IsUpper(ch))); // выбираем те строки, где символы в upperCase
            Logger.LogCollection(stringsList);
            Logger.LogCollection(stringsArray);
            Logger.LogCollection(onlyUpperCase);
            //
        }
    }
}