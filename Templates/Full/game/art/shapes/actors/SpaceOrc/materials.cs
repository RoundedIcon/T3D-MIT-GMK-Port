//*****************************************************************************
// Orc Materials
//*****************************************************************************
singleton Material(OrcEye)
{
   diffuseMap[0] = "orc_ID6_eye";
   emissive[0] = true;
   glow[0] = true;
};

singleton Material(SpaceOrc)
{
   diffuseMap[0] = "Orc_Material";
   normalMap[0] = "Orc_Material_normal";
   cubemap = WChrome;
   pixelSpecular[0] = true;
   specular[0] = "0.5 0.5 0.5 0.5";
   specularPower[0] = 8.0;
};

//*****************************************************************************
// Gun Materials
//*****************************************************************************
singleton Material(GunMetal)
{
   diffuseMap[0] = "Gun_Material";
   normalMap[0] = "Gun_Material_Normal";
//   cubemap = WChrome;
   pixelSpecular[0] = true;
//   specular[0] = "0.58 0.65 0.71 1.0";
   specular[0] = "1.0 1.0 1.0 1.0";
   specularPower[0] = 32.0;
   //emissive[1] = true;
   //glow[1] = true;
};

singleton Material(GunCamEyeThing)
{
   mapTo = "gun_ID5_cameyething";
   diffuseMap[0] = "orc_ID6_eye";
   emissive[0] = true;
   glow[0] = true;
};

