using UnityEngine;
using System.Collections;

public class mathfabs : MonoBehaviour {

    public float maRan;
    private float resul;

	void Start () {
       
    }

	void Update () {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Randi();
        }
	}

    void Randi()
    {
        maRan = Random.Range(-10, 3);
        resul = Mathf.Abs(maRan);
        print("Resultado random: " + maRan);
        print("Mathf.Abs: " + resul);
    }
}
