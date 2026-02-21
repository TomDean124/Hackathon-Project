using UnityEngine;
using System.Collections.Generic;

public class AttackManager : MonoBehaviour
{   
    //* Lists & Dictionaires * //
    public List<AttackAction> attackActions;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("L was pressed!");
            foreach(var _actions in attackActions)
            {
                if(_actions.keyRequired == KeyCode.L)
                {
                    _actions.Execute();
                }
            }
        }
    }
}
