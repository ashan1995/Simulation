using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LightSystem : MonoBehaviour {

	public GameObject[] south;
	public GameObject[] north;
	public GameObject[] west;
	public GameObject[] east;

    public GameObject[] southCross;
    public GameObject[] southCrossSub;

    public GameObject[] southD;
    public GameObject[] northD;
    public GameObject[] westD;
    public GameObject[] eastD;

    public bool SNforwardleft = false;
	public bool WEforwardleft = false;
	public bool SNside = false;
	public bool WEside = false;

    public bool GreenON = false;
   
    SignalLight sr;
    SignalLight sf;
    SignalLight sl;

    SignalLight nr;
    SignalLight nf;
    SignalLight nl;

    SignalLight snCrossMainS;
    SignalLight snCrossMainN;
    SignalLight snCrossSubL;
    SignalLight snCrossSubR;

    SignalLight wr;
    SignalLight wf;
    SignalLight wl;

    SignalLight er;
    SignalLight ef;
    SignalLight el;

    SignalLight srD;
    SignalLight sfD;
    SignalLight slD;

    SignalLight nrD;
    SignalLight nfD;
    SignalLight nlD;

    SignalLight wrD;
    SignalLight wfD;
    SignalLight wlD;

    SignalLight erD;
    SignalLight efD;
    SignalLight elD;


    // Use this for initialization
    void Start () {
		StartCoroutine(Example());
        sr = south[0].GetComponent<SignalLight>();
        sf = south[1].GetComponent<SignalLight>();
        sl = south[2].GetComponent<SignalLight>();

        nr = north[0].GetComponent<SignalLight>();
        nf = north[1].GetComponent<SignalLight>();
        nl = north[2].GetComponent<SignalLight>();

        snCrossMainS = southCross[0].GetComponent<SignalLight>();
        snCrossMainN = southCross[1].GetComponent<SignalLight>();
        snCrossSubL = southCrossSub[0].GetComponent<SignalLight>();
        snCrossSubR = southCrossSub[1].GetComponent<SignalLight>();

        wr = west[0].GetComponent<SignalLight>();
        wf = west[1].GetComponent<SignalLight>();
        wl = west[2].GetComponent<SignalLight>();

        er = east[0].GetComponent<SignalLight>();
        ef = east[1].GetComponent<SignalLight>();
        el = east[2].GetComponent<SignalLight>();

        srD = southD[0].GetComponent<SignalLight>();
        sfD = southD[1].GetComponent<SignalLight>();
        slD = southD[2].GetComponent<SignalLight>();

        nrD = northD[0].GetComponent<SignalLight>();
        nfD = northD[1].GetComponent<SignalLight>();
        nlD = northD[2].GetComponent<SignalLight>();

        wrD = westD[0].GetComponent<SignalLight>();
        wfD = westD[1].GetComponent<SignalLight>();
        wlD = westD[2].GetComponent<SignalLight>();

        erD = eastD[0].GetComponent<SignalLight>();
        efD = eastD[1].GetComponent<SignalLight>();
        elD = eastD[2].GetComponent<SignalLight>();

    }

    // Update is called once per frame
    void Update () {

			if(SNforwardleft){

                sr.RedOn();
                sf.GreenOn();
                sl.GreenOn();
				nr.RedOn();
				nf.GreenOn();
				nl.GreenOn();

            snCrossMainS.GreenOn();
            snCrossMainN.GreenOn();
            snCrossSubL.RedOn();
            snCrossSubR.RedOn();

            srD.RedOn();
            sfD.GreenOn();
            slD.GreenOn();
            nrD.RedOn();
            nfD.GreenOn();
            nlD.GreenOn();

            WestEastAllFalse();
				
			}else if(SNside){
                sr.GreenOn();
                sf.RedOn();
                sl.RedOn();
            
                nr.GreenOn();
                nf.RedOn();
                nl.RedOn();

            snCrossMainS.GreenOn();
            snCrossMainN.GreenOn();
            snCrossSubL.RedOn();
            snCrossSubR.RedOn();

            srD.GreenOn();
            sfD.RedOn();
            slD.RedOn();

            nrD.GreenOn();
            nfD.RedOn();
            nlD.RedOn();


            WestEastAllFalse();

			}else if(WEforwardleft){

				SouthNorathAllFalse();

                er.RedOn();
                ef.GreenOn();
                el.GreenOn();

                wr.RedOn();
                wf.GreenOn();
                wl.GreenOn();

            erD.RedOn();
            efD.GreenOn();
            elD.GreenOn();

            wrD.RedOn();
            wfD.GreenOn();
            wlD.GreenOn();

        }
        else if(WEside){
				
				SouthNorathAllFalse();

				er.GreenOn();
				ef.RedOn();
                el.RedOn();
            
                wr.GreenOn();
                wf.RedOn();
                wl.RedOn();

            erD.GreenOn();
            efD.RedOn();
            elD.RedOn();

            wrD.GreenOn();
            wfD.RedOn();
            wlD.RedOn();
        }

        



    }

	void SouthNorathAllFalse(){

                sr.RedOn();
                sf.RedOn();
                sl.RedOn();
       

                nr.RedOn();
                nf.RedOn();
                nl.RedOn();

        snCrossMainS.RedOn();
        snCrossMainN.RedOn();
        snCrossSubL.GreenOn();
        snCrossSubR.GreenOn();

        srD.RedOn();
        sfD.RedOn();
        slD.RedOn();


        nrD.RedOn();
        nfD.RedOn();
        nlD.RedOn();
    }

	void WestEastAllFalse(){

        erD.RedOn();
        efD.RedOn();
        elD.RedOn();


        wrD.RedOn();
        wfD.RedOn();
        wlD.RedOn();
    }



	IEnumerator Example()
    {

		WaitForSeconds waitTime = new WaitForSeconds(10);

        while(true){
			SNforwardleft=true;
			SNside=false;
			WEforwardleft=false;
			WEside=false;

			yield return waitTime;

			WEforwardleft=true;
			WEside=false;
			SNside=false;
			SNforwardleft=false;
			yield return waitTime;

			SNside=true;
			SNforwardleft=false;
			WEforwardleft=false;
			WEside=false;
			yield return waitTime;

			WEside=true;
			SNside=false;
			WEforwardleft=false;
			SNforwardleft=false;

			yield return waitTime;
		}
		
    }	
}
