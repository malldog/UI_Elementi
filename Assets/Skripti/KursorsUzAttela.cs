using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KursorsUzAttela : MonoBehaviour {

	public AudioSource skanasAvots;
	public AudioClip skanaKoAtskanot;

	public void uzbiditsUzAttelu(){
		skanasAvots.PlayOneShot(skanaKoAtskanot);
}
	public void kursorsNost(){
		skanasAvots.Stop();
	}



}
