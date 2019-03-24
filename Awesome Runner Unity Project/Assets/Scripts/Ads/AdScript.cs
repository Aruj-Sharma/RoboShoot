﻿using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        showBannerAd();

    }

    private void showBannerAd()
    {
        string adID = "ca-app-pub-3940256099942544/6300978111";

       

        //***For Production When Submit App***
       AdRequest request = new AdRequest.Builder().Build();

        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
        bannerAd.LoadAd(request);
    }

    // Update is called once per frame
    void Update()
    {

    }
}