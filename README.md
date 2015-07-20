# Unity-Project
University Project

using UnityEngine;			//****Librerias a utilizar
using System.Collections;

//**Este codigo permite que nuestro coche pueda perseguir a otro al indicarle los valores del mas cercano
//**Y asi atraparlo en la ruta mas corta disponible


public class PerseguirNavigation : MonoBehaviour { 	//** declaracion de las funciones a utilizar
	
	public GameObject destino;

	private NavMeshAgent agenteDeNavegacion; 


	void Start ( ) {       		//**Incio de ejecucion de codigo
					//**Creamos una subrutina en la cual le damos el valor de las funciones para calcular el camino de nuestro agente

		agenteDeNavegacion = gameObject.GetComponent<NavMeshAgent> ( );  //** Se emplea la libreria GetComponent() la cual nos permite obtener el valor del camino disponible para nuestro agente
	}									//** NavMeshAgent nos permite calcular el camino de nuestro agente el mismo se emplea cuadros posteriores, no retorna un valor Booleano 

	void Update ( ) {		//**Actualizacion de los valores de movimiento para nuestro agente

		agenteDeNavegacion.SetDestination ( destino.transform.position );
	}

}
