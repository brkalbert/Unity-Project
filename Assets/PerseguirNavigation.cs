using UnityEngine;
using System.Collections;

public class PerseguirNavigation : MonoBehaviour {
	
	public GameObject destino;
	private NavMeshAgent agenteDeNavegacion;

	void Start ( ) {
		agenteDeNavegacion = gameObject.GetComponent<NavMeshAgent> ( );
	}

	void Update ( ) {
		agenteDeNavegacion.SetDestination ( destino.transform.position );
	}

}
