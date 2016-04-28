//Maya ASCII 2016 scene
//Name: tapir.ma
//Last modified: Sat, Dec 05, 2015 03:26:02 PM
//Codeset: UTF-8
requires maya "2016";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2016";
fileInfo "version" "2016";
fileInfo "cutIdentifier" "201502261600-953408";
fileInfo "osv" "Mac OS X 10.9.1";
fileInfo "license" "student";
createNode transform -n "body";
	rename -uid "3A7DB305-6942-DE5C-F4C3-6E95BF4AE2EE";
createNode mesh -n "bodyShape" -p "body";
	rename -uid "F857FCA3-A740-1604-FF01-4E88AD86925F";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50000002980232239 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt";
	setAttr ".pt[4]" -type "float3" 0.063802488 0 0.059714086 ;
	setAttr ".pt[5]" -type "float3" -0.10648233 0 0.059714086 ;
	setAttr ".pt[51]" -type "float3" 0 -0.074026361 -0.053824823 ;
	setAttr ".pt[58]" -type "float3" 0 -0.074026361 -0.053824823 ;
createNode transform -n "frontrightleg";
	rename -uid "D906661D-2C4D-0EAA-A628-9DA50BCD2FF5";
createNode mesh -n "frontrightlegShape" -p "frontrightleg";
	rename -uid "AE91D1E1-D244-2CBF-4839-ECB9E758296F";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode transform -n "frontleftleg";
	rename -uid "11471EE5-7846-B40F-A60F-149B31E0DF37";
createNode mesh -n "frontleftlegShape" -p "frontleftleg";
	rename -uid "664D06BF-534E-ABAA-4DB9-59B3E4C0695B";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "backleftleg";
	rename -uid "17924101-A149-1D63-4084-4F9EF9CC4D67";
createNode mesh -n "backleftlegShape" -p "backleftleg";
	rename -uid "05586B65-924F-3430-7004-B586FF2574A7";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "backrightleg";
	rename -uid "99F5899F-D74B-0FE5-B6E9-DD9A58833FE9";
createNode mesh -n "backrightlegShape" -p "backrightleg";
	rename -uid "FA1E8BF3-2A42-501E-F905-249AF431C185";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "pCube1";
	rename -uid "D7DD867A-5243-9966-9133-10A408DDE164";
createNode mesh -n "pCubeShape1" -p "pCube1";
	rename -uid "0B8BA07F-3C41-8046-E8B4-29AAEC33A666";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.625 0.2129310667514801 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt";
	setAttr ".pt[0]" -type "float3" -0.051168386 0 -0.083306856 ;
	setAttr ".pt[1]" -type "float3" 0 0 -0.083306856 ;
	setAttr ".pt[44]" -type "float3" -0.051168386 0 -0.083306856 ;
	setAttr ".pt[47]" -type "float3" 0 0 -0.083306856 ;
	setAttr ".pt[75]" -type "float3" 0 -0.21089543 0 ;
	setAttr ".pt[76]" -type "float3" 0 -0.21089543 0 ;
	setAttr ".pt[77]" -type "float3" 0 -0.21089543 0 ;
	setAttr ".pt[78]" -type "float3" 0 -0.21089543 0 ;
createNode animCurveTL -n "body_translateX";
	rename -uid "1E6EC702-AB43-C0E0-D66D-808F7954FCDD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTL -n "body_translateY";
	rename -uid "D88828E3-E342-EA6F-2240-188AC1B3E29A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTL -n "body_translateZ";
	rename -uid "A838F47B-B544-676F-4C42-3C89770C8362";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTA -n "body_rotateX";
	rename -uid "08F2DA86-4446-200E-52CC-8797B6289BF0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTA -n "body_rotateY";
	rename -uid "DB4D1D8F-6345-9AF1-4F46-DEB6FD12ECE7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTA -n "body_rotateZ";
	rename -uid "5786EB36-DE4E-0011-45F2-DC9D566171AC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTU -n "body_scaleX";
	rename -uid "3662888E-524E-C7E4-FDC0-03B8D51D4E34";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.81574609364027684;
createNode animCurveTU -n "body_scaleY";
	rename -uid "59F1DD46-1840-19F9-0D13-A3BD76EDE2C0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
createNode animCurveTU -n "body_scaleZ";
	rename -uid "271F2FEE-8042-B34C-E9C2-0092C108EDF9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1.8897158744343574;
createNode animCurveTU -n "body_visibility";
	rename -uid "309964FD-F34D-6616-D79D-5ABAC45D264A";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
	setAttr ".kot[0]"  5;
createNode polySplit -n "polySplit20";
	rename -uid "662F246A-C247-169D-87D2-FAA9C99D26C3";
	setAttr -s 11 ".e[0:10]"  0.124038 0.87596202 0.124038 0.87596202 0.124038
		 0.124038 0.124038 0.124038 0.87596202 0.124038 0.124038;
	setAttr -s 11 ".d[0:10]"  -2147483616 -2147483564 -2147483614 -2147483556 -2147483573 -2147483613 
		-2147483612 -2147483611 -2147483561 -2147483593 -2147483616;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit19";
	rename -uid "7254742C-D841-B555-20BD-CFB2BC570E12";
	setAttr -s 11 ".e[0:10]"  0.109712 0.890288 0.890288 0.109712 0.890288
		 0.890288 0.890288 0.890288 0.109712 0.890288 0.109712;
	setAttr -s 11 ".d[0:10]"  -2147483627 -2147483616 -2147483593 -2147483568 -2147483611 -2147483612 
		-2147483613 -2147483573 -2147483588 -2147483614 -2147483627;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit18";
	rename -uid "5D170E61-064F-E493-2E2D-718875331AD8";
	setAttr -s 11 ".e[0:10]"  0.79749298 0.202507 0.202507 0.79749298 0.79749298
		 0.202507 0.79749298 0.79749298 0.202507 0.202507 0.79749298;
	setAttr -s 11 ".d[0:10]"  -2147483640 -2147483597 -2147483598 -2147483639 -2147483631 -2147483601 
		-2147483617 -2147483605 -2147483604 -2147483595 -2147483640;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit17";
	rename -uid "5A28AFA2-4A4A-7B56-58C8-58AA710A300C";
	setAttr -s 11 ".e[0:10]"  0.49178201 0.50821799 0.50821799 0.49178201
		 0.50821799 0.50821799 0.49178201 0.49178201 0.50821799 0.49178201 0.49178201;
	setAttr -s 11 ".d[0:10]"  -2147483644 -2147483605 -2147483617 -2147483643 -2147483631 -2147483639 
		-2147483620 -2147483608 -2147483640 -2147483629 -2147483644;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit16";
	rename -uid "6445E075-7242-1701-23CD-0CA6D86EAD36";
	setAttr -s 7 ".e[0:6]"  0.53085101 0.46914899 0.53085101 0.53085101
		 0.53085101 0.53085101 0.53085101;
	setAttr -s 7 ".d[0:6]"  -2147483648 -2147483627 -2147483645 -2147483646 -2147483632 -2147483647 
		-2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit15";
	rename -uid "BEC6B88E-7141-888D-BF0F-0CB04528C944";
	setAttr -s 7 ".e[0:6]"  0.65040803 0.349592 0.65040803 0.65040803
		 0.65040803 0.65040803 0.65040803;
	setAttr -s 7 ".d[0:6]"  -2147483648 -2147483630 -2147483645 -2147483646 -2147483632 -2147483647 
		-2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak3";
	rename -uid "3A03C7AB-584B-115A-3ADC-D69802223CD1";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk[4:5]" -type "float3"  0 -0.27278054 0 0 -0.27278054
		 0;
createNode polySplit -n "polySplit14";
	rename -uid "A9298A15-AA40-11A3-690D-2BA84D67BB6A";
	setAttr -s 5 ".e[0:4]"  0.474628 0.474628 0.52537203 0.52537203 0.474628;
	setAttr -s 5 ".d[0:4]"  -2147483642 -2147483641 -2147483637 -2147483638 -2147483642;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak2";
	rename -uid "43E44B39-EC49-4387-9EFF-47B7B9C7BE8E";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk[2:3]" -type "float3"  0 -0.25854659 0 0 -0.25854659
		 0;
createNode polyCube -n "polyCube1";
	rename -uid "A4B462A1-2447-BAC7-56DD-6D8D05EBA38E";
	setAttr ".cuv" 4;
createNode animCurveTL -n "frontrightleg_translateX";
	rename -uid "52187A76-9C4F-5C4E-C837-109515A7B932";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 -0.267 10 -0.267 15 -0.267 25 -0.267 35 -0.267
		 36 -0.267 45 -0.267 55 -0.267;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTL -n "frontrightleg_translateY";
	rename -uid "82636480-A849-4FCF-6F41-BCB2FCFEDC50";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 -0.59096410993752713 10 -0.59096410993752713
		 15 -0.59096410993752713 25 -0.59096410993752713 35 -0.59096410993752713 36 -0.59096410993752713
		 45 -0.59096410993752713 55 -0.59096410993752713;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTL -n "frontrightleg_translateZ";
	rename -uid "8D67DC7E-2F4B-2DEE-B767-B28B7B3EA903";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0.76263636679593794 10 0.76263636679593794
		 15 0.76263636679593794 25 0.70970234727125703 35 0.76263636679593794 36 0.76263636679593794
		 45 0.86838660005943114 55 0.76263636679593794;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTA -n "frontrightleg_rotateX";
	rename -uid "35CE4EDF-D146-6C23-634D-84B1A7B0B01E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0 10 0 15 0 25 17.008356443038625 35 0
		 36 0 45 -19.725944805150718 55 0;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTA -n "frontrightleg_rotateY";
	rename -uid "18531C73-DE45-1C11-7901-97B7E5406B95";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0 10 0 15 0 25 0 35 0 36 0 45 0 55 0;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTA -n "frontrightleg_rotateZ";
	rename -uid "0B3FDDA0-1C44-CBA0-5FBF-13895DB93DC6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0 10 0 15 0 25 0 35 0 36 0 45 0 55 0;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTU -n "frontrightleg_scaleX";
	rename -uid "DF0E76B9-0941-489C-668F-B4A23A6C4016";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.22968442609833026;
createNode animCurveTU -n "frontrightleg_scaleY";
	rename -uid "ADBDA77E-DE43-E6E2-3931-5EA5E9C18EE9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
createNode animCurveTU -n "frontrightleg_scaleZ";
	rename -uid "2C402DE9-734F-FD1D-6C11-8FA0E347D630";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.2495216561858753;
createNode animCurveTU -n "frontrightleg_visibility";
	rename -uid "350CBCDA-104C-B1BA-46C0-86B159769996";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
	setAttr ".kot[0]"  5;
createNode polyCube -n "polyCube2";
	rename -uid "9765BA95-E84A-EBEC-7E48-2AABA27DA736";
	setAttr ".cuv" 4;
createNode materialInfo -n "materialInfo1";
	rename -uid "93E398E7-E949-2165-F091-0592D2567839";
createNode shadingEngine -n "lambert2SG";
	rename -uid "6B5E23F9-8C42-1D68-2045-B7AF7994D7B7";
	setAttr ".ihi" 0;
	setAttr -s 4 ".dsm";
	setAttr ".ro" yes;
createNode lambert -n "lambert2";
	rename -uid "3259664C-2A4A-AAFF-9710-1294FE5C51F6";
	setAttr ".c" -type "float3" 0.35771725 0.35771725 0.35771725 ;
createNode animCurveTA -n "frontleftleg_rotateX";
	rename -uid "CCFDD814-6247-08F9-5871-1888E4275069";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 0 15 0 25 -16.858741015065799 35 0.20602783390693957
		 36 0.20602783390693957 46 19.917093315566554 56 0;
createNode animCurveTA -n "frontleftleg_rotateY";
	rename -uid "9957B8C0-E840-B8EB-3E47-AEA8B3E1ACFF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 0 15 0 25 0 35 0 36 0 46 0 56 0;
createNode animCurveTA -n "frontleftleg_rotateZ";
	rename -uid "191055AD-EB4A-B9BA-5C53-3AB2BD1746B6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 0 15 0 25 0 35 0 36 0 46 0 56 0;
createNode animCurveTL -n "frontleftleg_translateX";
	rename -uid "C2823D49-AF43-1936-3D1A-14B61CF1ACDF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 0.27907069075856361 15 0.27907069075856361
		 25 0.27907069075856361 35 0.27907069075856361 36 0.27907069075856361 46 0.27907069075856361
		 56 0.27907069075856361;
createNode animCurveTL -n "frontleftleg_translateY";
	rename -uid "35104B95-B845-2793-4ADB-EF94AD6A1FDD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 -0.59096410993752713 15 -0.59096410993752713
		 25 -0.59096410993752713 35 -0.59096410993752713 36 -0.59096410993752713 46 -0.59096410993752713
		 56 -0.59096410993752713;
createNode animCurveTL -n "frontleftleg_translateZ";
	rename -uid "E48EE3FD-5549-94D9-3ED1-51818811DAFB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 0.7558285058891907 15 0.7558285058891907
		 25 0.8158295314524473 35 0.7558285058891907 36 0.7558285058891907 46 0.68689472214143099
		 56 0.756;
createNode animCurveTU -n "frontleftleg_scaleX";
	rename -uid "71D15529-E443-43F1-B0F5-48B7535E800B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.22968442609833026;
createNode animCurveTU -n "frontleftleg_scaleY";
	rename -uid "1CE069B3-0F42-0B56-8A5C-FDA2F2DD6E23";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
createNode animCurveTU -n "frontleftleg_scaleZ";
	rename -uid "F14956D5-7945-9C5B-295B-FCAE929EF638";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.2495216561858753;
createNode animCurveTU -n "frontleftleg_visibility";
	rename -uid "A2775F22-F447-A8B4-ADCB-16AA358E8EF8";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
	setAttr ".kot[0]"  5;
createNode animCurveTL -n "backleftleg_translateX";
	rename -uid "E1C24C55-9D47-5218-3E8F-8AA8098F48CC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0.27955261598639503 10 0.27955261598639503
		 15 0.27955261598639503 25 0.27955261598639503 35 0.27955261598639503 36 0.27955261598639503
		 45 0.27955261598639503 55 0.27955261598639503;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTL -n "backleftleg_translateY";
	rename -uid "D84D0DD2-DD4B-1BEE-23AB-41AB8318320F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 -0.59096410993752713 10 -0.59096410993752713
		 15 -0.59096410993752713 25 -0.59096410993752713 35 -0.59096410993752713 36 -0.59096410993752713
		 45 -0.59096410993752713 55 -0.59096410993752713;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTL -n "backleftleg_translateZ";
	rename -uid "5DEC6BAE-2740-7214-C85D-8E85BF40A009";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 -0.7344993489643572 10 -0.7344993489643572
		 15 -0.7344993489643572 25 -0.78743336848903811 35 -0.7344993489643572 36 -0.7344993489643572
		 45 -0.628749115700864 55 -0.7344993489643572;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTA -n "backleftleg_rotateX";
	rename -uid "0A4A4E3A-DD4F-6DA4-5F3E-EB95C21F86F5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0 10 0 15 0 25 17.008356443038625 35 0
		 36 0 45 -19.725944805150718 55 0;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTA -n "backleftleg_rotateY";
	rename -uid "1191CB1B-A24D-0366-1EE3-778ABA0B29FA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0 10 0 15 0 25 0 35 0 36 0 45 0 55 0;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTA -n "backleftleg_rotateZ";
	rename -uid "43C699BD-BB42-D30A-419A-FEADE4A6B616";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0 10 0 15 0 25 0 35 0 36 0 45 0 55 0;
	setAttr -s 8 ".kit[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kot[2:7]"  1 1 1 18 18 1;
	setAttr -s 8 ".kix[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".kiy[2:7]"  0 0 0 0 0 0;
	setAttr -s 8 ".kox[2:7]"  1 1 1 1 1 1;
	setAttr -s 8 ".koy[2:7]"  0 0 0 0 0 0;
createNode animCurveTU -n "backleftleg_scaleX";
	rename -uid "9FF9FE94-B342-2929-E285-4283C3711982";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.22968442609833026;
createNode animCurveTU -n "backleftleg_scaleY";
	rename -uid "6AB23CCE-1047-DE18-8493-57974A02C3AE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
createNode animCurveTU -n "backleftleg_scaleZ";
	rename -uid "7A0378D3-784D-C4A7-7C91-84B05DC44DF9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.2495216561858753;
createNode animCurveTU -n "backleftleg_visibility";
	rename -uid "F8639072-F349-5B77-F52A-0DAC4A7FACCD";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
	setAttr ".kot[0]"  5;
createNode animCurveTA -n "backrightleg_rotateX";
	rename -uid "6EAD3181-A14D-8326-A9CB-7C99C12D8FF6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0 10 0 15 0 25 -16.858741015065799 35 0.20602783390693957
		 36 0.20602783390693957 46 19.917093315566554 56 0;
createNode animCurveTA -n "backrightleg_rotateY";
	rename -uid "AF745D8C-094E-7D28-D1C4-C18152B7EFFE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0 10 0 15 0 25 0 35 0 36 0 46 0 56 0;
createNode animCurveTA -n "backrightleg_rotateZ";
	rename -uid "ADE3A63F-D543-19BB-385D-6B9521A1859E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0 10 0 15 0 25 0 35 0 36 0 46 0 56 0;
createNode animCurveTL -n "backrightleg_translateX";
	rename -uid "6E554C9B-DF49-936C-4DFA-D28B68E11B8C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 -0.26701068358675201 10 -0.26701068358675201
		 15 -0.267 25 -0.267 35 -0.267 36 -0.267 46 -0.267 56 -0.267;
createNode animCurveTL -n "backrightleg_translateY";
	rename -uid "DB825A83-8F4B-D7A3-7EBF-368F7B704106";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 -0.59096410993752713 10 -0.59096410993752713
		 15 -0.59096410993752713 25 -0.59096410993752713 35 -0.59096410993752713 36 -0.59096410993752713
		 46 -0.59096410993752713 56 -0.59096410993752713;
createNode animCurveTL -n "backrightleg_translateZ";
	rename -uid "93D596C3-DB4B-D4DB-88D7-709628CCDDA6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 -0.7344993489643572 10 -0.7344993489643572
		 15 -0.7344993489643572 25 -0.67449832340110061 35 -0.7344993489643572 36 -0.7344993489643572
		 46 -0.80343313271211692 56 -0.734;
createNode animCurveTU -n "backrightleg_scaleX";
	rename -uid "6F772115-C445-97AD-F7BF-4289C7513843";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.22968442609833026;
createNode animCurveTU -n "backrightleg_scaleY";
	rename -uid "1E69A0BF-D848-80BC-5868-1B95C57C5A24";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
createNode animCurveTU -n "backrightleg_scaleZ";
	rename -uid "E375C2E2-E04B-2616-9C55-D39BC2507087";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.2495216561858753;
createNode animCurveTU -n "backrightleg_visibility";
	rename -uid "FE68A2C8-374B-9FBB-CB4F-878F083E8075";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
	setAttr ".kot[0]"  5;
createNode animCurveTL -n "pCube1_translateX";
	rename -uid "077FC2DE-4645-16DD-4D5F-28A86AC9EE73";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTL -n "pCube1_translateY";
	rename -uid "B4B47B13-B440-8FE9-0F89-6C875C81F4A6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 -0.050221916188440296;
createNode animCurveTL -n "pCube1_translateZ";
	rename -uid "FBE62E81-F248-BF2F-4BBD-58A2BEB2B275";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.96033435893082131;
createNode animCurveTA -n "pCube1_rotateX";
	rename -uid "F30A366A-3447-847A-33D5-6F9C7EEF14E8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTA -n "pCube1_rotateY";
	rename -uid "09FF5670-3049-F346-2AEB-5E9B87F6F553";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTA -n "pCube1_rotateZ";
	rename -uid "0BE96540-DD4F-EA5C-E50E-5693B38B0594";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTU -n "pCube1_scaleX";
	rename -uid "C9183147-3140-57E6-F32F-B78254FCED72";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.81574609364027684;
createNode animCurveTU -n "pCube1_scaleY";
	rename -uid "AD874122-1A4C-A836-5ACF-EB88599257E6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 0.59519643283937029;
createNode animCurveTU -n "pCube1_scaleZ";
	rename -uid "BF7684B9-0B4A-7911-7265-FFB77C9B0A99";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
createNode animCurveTU -n "pCube1_visibility";
	rename -uid "682EFA7E-204A-1511-CEDF-A1AB8129AD58";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr ".ktv[0]"  1 1;
	setAttr ".kot[0]"  5;
createNode polyExtrudeFace -n "polyExtrudeFace1";
	rename -uid "C766C07C-C24E-8095-3F71-B5894BD53A2F";
	setAttr ".ics" -type "componentList" 1 "f[43]";
	setAttr ".ix" -type "matrix" 0.81574609364027684 0 0 0 0 0.59519643283937029 0 0
		 0 0 1 0 0 -0.050221916188440296 0.96033435893082131 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.026982049 -0.27018237 1.8076574 ;
	setAttr ".rs" 35738807;
	setAttr ".lt" -type "double3" 0 5.5511151231257827e-17 0.21855958752990134 ;
	setAttr ".off" 0.05000000074505806;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.11252057977684232 -0.36344907946729371 1.8076573593618821 ;
	setAttr ".cbx" -type "double3" 0.05855648201233634 -0.17691568794034121 1.8076573593618821 ;
createNode polyTweak -n "polyTweak4";
	rename -uid "D9E9E9BD-304E-5E74-FF46-5DB9FDF0E455";
	setAttr ".uopa" yes;
	setAttr -s 21 ".tk";
	setAttr ".tk[2]" -type "float3" 0.057757024 0.25005907 0 ;
	setAttr ".tk[3]" -type "float3" -0.047987998 0.25005907 0 ;
	setAttr ".tk[8]" -type "float3" 0.057757024 0.25005907 0 ;
	setAttr ".tk[9]" -type "float3" -0.047987998 0.25005907 0 ;
	setAttr ".tk[22]" -type "float3" 0.054125275 0.25005907 0 ;
	setAttr ".tk[23]" -type "float3" 0.054125275 0.25005907 0 ;
	setAttr ".tk[24]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[25]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[26]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[27]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[28]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[29]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[30]" -type "float3" -0.14134811 0.25005907 0 ;
	setAttr ".tk[31]" -type "float3" -0.14134811 0.25005907 0 ;
	setAttr ".tk[33]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[40]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[45]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[52]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[60]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[67]" -type "float3" -0.11803285 0 0 ;
	setAttr ".tk[71]" -type "float3" 7.4505806e-09 0.25005907 0 ;
createNode polySplit -n "polySplit13";
	rename -uid "DD893FAF-714D-B323-980D-9B827AFA7F95";
	setAttr -s 2 ".e[0:1]"  1 0.56699902;
	setAttr -s 2 ".d[0:1]"  -2147483535 -2147483508;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit12";
	rename -uid "A2C02631-DD4C-CDEC-2750-218EAB48EFC9";
	setAttr -s 5 ".e[0:4]"  1 0.85413498 1 0.18028601 0;
	setAttr -s 5 ".d[0:4]"  -2147483537 -2147483598 -2147483540 -2147483598 -2147483540;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit11";
	rename -uid "0914B262-9342-907B-DE26-3D8A7F57936D";
	setAttr ".e[0]"  0.53268701;
	setAttr ".d[0]"  -2147483613;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit10";
	rename -uid "B0BE245B-1A48-FEA4-DE03-D1A94E05A2F7";
	setAttr -s 13 ".e[0:12]"  0.091358103 0.90864199 0.90864199 0.091358103
		 0.90864199 0.091358103 0.90864199 0.091358103 0.091358103 0.90864199 0.90864199 0.091358103
		 0.091358103;
	setAttr -s 13 ".d[0:12]"  -2147483640 -2147483580 -2147483581 -2147483639 -2147483583 -2147483631 
		-2147483585 -2147483605 -2147483589 -2147483588 -2147483577 -2147483621 -2147483640;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit9";
	rename -uid "0A8A7F94-8E45-C71F-F773-CC94C6EEE11C";
	setAttr -s 3 ".e[0:2]"  1 0.441659 1;
	setAttr -s 3 ".d[0:2]"  -2147483598 -2147483615 -2147483591;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit8";
	rename -uid "24195054-A74B-29AE-CEB4-24BDB0116951";
	setAttr -s 2 ".e[0:1]"  0.90178001 0;
	setAttr -s 2 ".d[0:1]"  -2147483540 -2147483606;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit7";
	rename -uid "D3F0742A-844B-7454-9443-D4B6792D88C3";
	setAttr -s 2 ".e[0:1]"  0.069268897 0;
	setAttr -s 2 ".d[0:1]"  -2147483597 -2147483598;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak1";
	rename -uid "776ED43C-E241-8A61-F0C1-B1AF694432F7";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk";
	setAttr ".tk[0]" -type "float3" 0.31475428 -0.026258491 0.347323 ;
	setAttr ".tk[1]" -type "float3" -0.31475428 -0.026258491 0.347323 ;
	setAttr ".tk[16]" -type "float3" -0.12196729 -0.026258491 0.347323 ;
	setAttr ".tk[24]" -type "float3" 0.033817403 -0.026258491 0.347323 ;
	setAttr ".tk[44]" -type "float3" 0.31475428 -0.3605791 0.347323 ;
	setAttr ".tk[45]" -type "float3" 0.033817403 -0.36057916 0.347323 ;
	setAttr ".tk[46]" -type "float3" -0.12196731 -0.36057916 0.347323 ;
	setAttr ".tk[47]" -type "float3" -0.31475428 -0.3605791 0.347323 ;
createNode polySplit -n "polySplit6";
	rename -uid "454BAA55-C646-458D-99CD-E8ADA75D4295";
	setAttr -s 13 ".e[0:12]"  0.88938999 0.11061 0.11061 0.88938999 0.11061
		 0.88938999 0.11061 0.88938999 0.88938999 0.11061 0.11061 0.88938999 0.88938999;
	setAttr -s 13 ".d[0:12]"  -2147483644 -2147483587 -2147483586 -2147483643 -2147483584 -2147483623 
		-2147483582 -2147483609 -2147483593 -2147483579 -2147483578 -2147483629 -2147483644;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit5";
	rename -uid "B3A2AE00-B34D-8614-CA35-79AA0CF77D48";
	setAttr -s 13 ".e[0:12]"  0.72827297 0.271727 0.271727 0.72827297 0.271727
		 0.72827297 0.271727 0.72827297 0.72827297 0.271727 0.271727 0.72827297 0.72827297;
	setAttr -s 13 ".d[0:12]"  -2147483644 -2147483589 -2147483605 -2147483643 -2147483631 -2147483623 
		-2147483639 -2147483609 -2147483593 -2147483640 -2147483621 -2147483629 -2147483644;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit4";
	rename -uid "1DB37274-AF42-43C6-9CBC-668D4DE499BD";
	setAttr -s 9 ".e[0:8]"  0.64328599 0.35671401 0.64328599 0.64328599
		 0.64328599 0.35671401 0.64328599 0.64328599 0.64328599;
	setAttr -s 9 ".d[0:8]"  -2147483648 -2147483619 -2147483624 -2147483645 -2147483646 -2147483615 
		-2147483632 -2147483647 -2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit3";
	rename -uid "53BC206E-8049-8BB0-EEAF-5A90CE2DD29E";
	setAttr -s 9 ".e[0:8]"  0.69375002 0.30625001 0.69375002 0.69375002
		 0.69375002 0.30625001 0.69375002 0.69375002 0.69375002;
	setAttr -s 9 ".d[0:8]"  -2147483648 -2147483630 -2147483624 -2147483645 -2147483646 -2147483622 
		-2147483632 -2147483647 -2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit2";
	rename -uid "3FCC430D-DC4B-AE2F-3BE4-D8A100C3E8AE";
	setAttr -s 5 ".e[0:4]"  0.96694702 0.96694702 0.033053201 0.033053201
		 0.96694702;
	setAttr -s 5 ".d[0:4]"  -2147483638 -2147483637 -2147483635 -2147483636 -2147483638;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit1";
	rename -uid "78B55893-9B45-DF21-8659-87AB6EA67B14";
	setAttr -s 5 ".e[0:4]"  0.114596 0.114596 0.88540399 0.88540399 0.114596;
	setAttr -s 5 ".d[0:4]"  -2147483642 -2147483641 -2147483637 -2147483638 -2147483642;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyCube -n "polyCube3";
	rename -uid "0B2BA62A-D349-4808-008C-B08593C27271";
	setAttr ".cuv" 4;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "C53DE4AF-DF4E-B9A4-769E-F28960EC5ED2";
	setAttr -s 3 ".lnk";
	setAttr -s 3 ".slnk";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 3 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 2 ".dsm";
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "body_translateX.o" "body.tx";
connectAttr "body_translateY.o" "body.ty";
connectAttr "body_translateZ.o" "body.tz";
connectAttr "body_rotateX.o" "body.rx";
connectAttr "body_rotateY.o" "body.ry";
connectAttr "body_rotateZ.o" "body.rz";
connectAttr "body_scaleX.o" "body.sx";
connectAttr "body_scaleY.o" "body.sy";
connectAttr "body_scaleZ.o" "body.sz";
connectAttr "body_visibility.o" "body.v";
connectAttr "polySplit20.out" "bodyShape.i";
connectAttr "frontrightleg_translateX.o" "frontrightleg.tx";
connectAttr "frontrightleg_translateY.o" "frontrightleg.ty";
connectAttr "frontrightleg_translateZ.o" "frontrightleg.tz";
connectAttr "frontrightleg_rotateX.o" "frontrightleg.rx";
connectAttr "frontrightleg_rotateY.o" "frontrightleg.ry";
connectAttr "frontrightleg_rotateZ.o" "frontrightleg.rz";
connectAttr "frontrightleg_scaleX.o" "frontrightleg.sx";
connectAttr "frontrightleg_scaleY.o" "frontrightleg.sy";
connectAttr "frontrightleg_scaleZ.o" "frontrightleg.sz";
connectAttr "frontrightleg_visibility.o" "frontrightleg.v";
connectAttr "polyCube2.out" "frontrightlegShape.i";
connectAttr "frontleftleg_rotateX.o" "frontleftleg.rx";
connectAttr "frontleftleg_rotateY.o" "frontleftleg.ry";
connectAttr "frontleftleg_rotateZ.o" "frontleftleg.rz";
connectAttr "frontleftleg_translateX.o" "frontleftleg.tx";
connectAttr "frontleftleg_translateY.o" "frontleftleg.ty";
connectAttr "frontleftleg_translateZ.o" "frontleftleg.tz";
connectAttr "frontleftleg_scaleX.o" "frontleftleg.sx";
connectAttr "frontleftleg_scaleY.o" "frontleftleg.sy";
connectAttr "frontleftleg_scaleZ.o" "frontleftleg.sz";
connectAttr "frontleftleg_visibility.o" "frontleftleg.v";
connectAttr "backleftleg_translateX.o" "backleftleg.tx";
connectAttr "backleftleg_translateY.o" "backleftleg.ty";
connectAttr "backleftleg_translateZ.o" "backleftleg.tz";
connectAttr "backleftleg_rotateX.o" "backleftleg.rx";
connectAttr "backleftleg_rotateY.o" "backleftleg.ry";
connectAttr "backleftleg_rotateZ.o" "backleftleg.rz";
connectAttr "backleftleg_scaleX.o" "backleftleg.sx";
connectAttr "backleftleg_scaleY.o" "backleftleg.sy";
connectAttr "backleftleg_scaleZ.o" "backleftleg.sz";
connectAttr "backleftleg_visibility.o" "backleftleg.v";
connectAttr "backrightleg_rotateX.o" "backrightleg.rx";
connectAttr "backrightleg_rotateY.o" "backrightleg.ry";
connectAttr "backrightleg_rotateZ.o" "backrightleg.rz";
connectAttr "backrightleg_translateX.o" "backrightleg.tx";
connectAttr "backrightleg_translateY.o" "backrightleg.ty";
connectAttr "backrightleg_translateZ.o" "backrightleg.tz";
connectAttr "backrightleg_scaleX.o" "backrightleg.sx";
connectAttr "backrightleg_scaleY.o" "backrightleg.sy";
connectAttr "backrightleg_scaleZ.o" "backrightleg.sz";
connectAttr "backrightleg_visibility.o" "backrightleg.v";
connectAttr "pCube1_translateX.o" "pCube1.tx";
connectAttr "pCube1_translateY.o" "pCube1.ty";
connectAttr "pCube1_translateZ.o" "pCube1.tz";
connectAttr "pCube1_rotateX.o" "pCube1.rx";
connectAttr "pCube1_rotateY.o" "pCube1.ry";
connectAttr "pCube1_rotateZ.o" "pCube1.rz";
connectAttr "pCube1_scaleX.o" "pCube1.sx";
connectAttr "pCube1_scaleY.o" "pCube1.sy";
connectAttr "pCube1_scaleZ.o" "pCube1.sz";
connectAttr "pCube1_visibility.o" "pCube1.v";
connectAttr "polyExtrudeFace1.out" "pCubeShape1.i";
connectAttr "polySplit19.out" "polySplit20.ip";
connectAttr "polySplit18.out" "polySplit19.ip";
connectAttr "polySplit17.out" "polySplit18.ip";
connectAttr "polySplit16.out" "polySplit17.ip";
connectAttr "polySplit15.out" "polySplit16.ip";
connectAttr "polyTweak3.out" "polySplit15.ip";
connectAttr "polySplit14.out" "polyTweak3.ip";
connectAttr "polyTweak2.out" "polySplit14.ip";
connectAttr "polyCube1.out" "polyTweak2.ip";
connectAttr "lambert2SG.msg" "materialInfo1.sg";
connectAttr "lambert2.msg" "materialInfo1.m";
connectAttr "lambert2.oc" "lambert2SG.ss";
connectAttr "backrightlegShape.iog" "lambert2SG.dsm" -na;
connectAttr "backleftlegShape.iog" "lambert2SG.dsm" -na;
connectAttr "frontleftlegShape.iog" "lambert2SG.dsm" -na;
connectAttr "frontrightlegShape.iog" "lambert2SG.dsm" -na;
connectAttr "polyTweak4.out" "polyExtrudeFace1.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace1.mp";
connectAttr "polySplit13.out" "polyTweak4.ip";
connectAttr "polySplit12.out" "polySplit13.ip";
connectAttr "polySplit11.out" "polySplit12.ip";
connectAttr "polySplit10.out" "polySplit11.ip";
connectAttr "polySplit9.out" "polySplit10.ip";
connectAttr "polySplit8.out" "polySplit9.ip";
connectAttr "polySplit7.out" "polySplit8.ip";
connectAttr "polyTweak1.out" "polySplit7.ip";
connectAttr "polySplit6.out" "polyTweak1.ip";
connectAttr "polySplit5.out" "polySplit6.ip";
connectAttr "polySplit4.out" "polySplit5.ip";
connectAttr "polySplit3.out" "polySplit4.ip";
connectAttr "polySplit2.out" "polySplit3.ip";
connectAttr "polySplit1.out" "polySplit2.ip";
connectAttr "polyCube3.out" "polySplit1.ip";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
connectAttr "lambert2SG.pa" ":renderPartition.st" -na;
connectAttr "lambert2.msg" ":defaultShaderList1.s" -na;
connectAttr "bodyShape.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
// End of tapir.ma
