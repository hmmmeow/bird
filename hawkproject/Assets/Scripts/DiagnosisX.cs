using UnityEngine;
using System.Collections;

public class DiagnosisX : MonoBehaviour {

		
	void Records(){

	
		string[,] records = new string[19,9] {
		{"Squits","Diarrhoea","Tender","High","Raised CRP","Normal","Normal","Normal","Squitamol"},
		{"Butterflitis","Diarrhoea","Normal","Normal","Normal","Butterflies","Normal","Normal","Amoxicitol"},
		{"Bowel entanglement","Diarrhoea","Tender","Normal","Normal","Normal","Entangled bowel","Normal","Transplant"},
		{"Hairyitis","Itchy","Hairy","High","Raised CRP","Normal","Normal","Normal","Electrolysis"},
		{"Dendritic rash","Itchy","Normal","Normal","Normal","Normal","Normal","Normal","Placebolin"},
		{"Light liver","Itchy","Normal","Normal","Deranged LFTs","Small liver","Normal","Normal","Transplant"},
		{"Crumblies","Back pain","Normal","Normal","Crumblies protein","Normal","Normal","Normal","Tixabrufen"},
		{"Spinal fusion","Back pain","Tender","Normal","Normal","Normal","Fused vertebrae","Normal","Decompression"},
		{"Rakeback syndrome","Back pain","Tender","Normal","Normal","Normal","Normal","Normal","Placebolin"},
		{"Lockjaw","Cannot speak","Lockjaw","Normal","Normal","Normal","Normal","Normal","Placebolin"},
		{"Mandibilitis","Cannot speak","Normal","High","Raised CRP","Normal","Normal","Normal","Squitamol"},
		{"Small brain anamoly","Cannot speak","Normal","Normal","Normal","Normal","Normal","Half brain","Transplant"},
		{"Radiolitis","Cannot see","Illuminates","Normal","Raised CRP","Normal","Normal","Normal","Amoxicitol"},
		{"Eye of Cthulyitis","Cannot see","Normal","Normal","Raised CRP","Inflammed eyes","Normal","Normal","Electrolysis"},
		{"Retinal polarisation","Cannot see","Normal","Normal","Polar antibodies","Normal","Normal","Normal","Transplant"},
		{"Distress syndrome","Breathless","Agitated","Normal","Normal","Normal","Normal","Normal","Placebolin"},
		{"Iron lung","Breathless","Normal","Normal","Normal","Normal","Iron lung","Normal","Transplant"},
		{"Chestdydilitis","Breathless","Normal","High","Raised CRP","Normal","Normal","Normal","Amoxicitol"},
		{"Plasmafied pleura","Breathless","Normal","High","Normal","Normal","Normal","Plasma","Decompression"}
		};

		print (records [0,0]);

	}



//	void Awake(){
//		Records ();
//	}



}
