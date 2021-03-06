﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Easy_Playable_Maker
{
	public partial class OneMeshPlayable : Form
	{
		public OneMeshPlayable()
		{
			InitializeComponent();
            TestBox.Hide();
            textBox1.Hide();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			string[] Funnies = {"","","","","","","","","","","",""};
			//I don't wanna be known for my mods, but rather as that guy who puts recipes in his mods :)
			Funnies[0] = "\n \n/*\nobligatory developer jokes are old news, here is a recipe for banana bread \n \nIngredients \n \n    2 to 3 very ripe bananas, peeled (about 1 1/4 to 1 1/2 cups mashed) \n    1/3 cup melted butter, unsalted or salted \n    1 teaspoon baking soda \n    Pinch of salt \n    3/4 cup sugar (1/2 cup if you would like it less sweet, 1 cup if more sweet) \n    1 large egg, beaten \n    1 teaspoon vanilla extract \n    1 1/2 cups of all-purpose flour \n \nMethod \n \n1 Preheat the oven to 350°F (175°C), and butter a 4x8-inch loaf pan. \n \n2 In a mixing bowl, mash the ripe bananas with a fork until completely smooth. Stir the melted butter into the mashed bananas. \n \n3 Mix in the baking soda and salt. Stir in the sugar, beaten egg, and vanilla extract. Mix in the flour. \n \n4 Pour the batter into your prepared loaf pan. Bake for 50 minutes to 1 hour at 350°F (175°C), or until a tester inserted into the center comes out clean. \n \n5 Remove from oven and let cool in the pan for a few minutes. Then remove the banana bread from the pan and let cool completely before serving. Slice and serve. (A bread knife helps to make slices that aren't crumbly.) \n*/";
			Funnies[1] = "\n \n/*\nChocolate Chip Cookies: \n1 cup butter, softened \n \n1 cup white sugar \n \n1 cup packed brown sugar \n \n2 large eggs eggs \n \n2 teaspoons vanilla extract \n \n1 teaspoon baking soda \n \n2 teaspoons hot water \n \n½ teaspoon salt \n \n3 cups all-purpose flour \n \n2 cups semisweet chocolate chips \n \n1 cup chopped walnuts \n \nPreheat oven to 350 degrees F (175 degrees C). \n \nStep 2 \nCream together the butter, white sugar, and brown sugar until smooth. Beat in the eggs one at a time, then stir in the vanilla. Dissolve baking soda in hot water. Add to batter along with salt. Stir in flour, chocolate chips, and nuts. Drop by large spoonfuls onto ungreased pans. \n \nStep 3 \nBake for about 10 minutes in the preheated oven, or until edges are nicely browned.\n*/";
			Funnies[2] = "\n \n/*\nTexas Toast; \n8 tablespoons (1 stick) unsalted butter \n \n2 tablespoons olive oil \n \n5 cloves garlic, minced \n \n1/2 teaspoon dried parsley \n \n1/2 teaspoon dried garlic \n \n1/4 teaspoon kosher salt \n \n1/4 teaspoon freshly ground black pepper \n \n1 loaf soft white bread or Texas toast bread (14-inch, 12 ounces) \n \nArrange a rack in the middle of oven, place a rimmed baking sheet on the rack to preheat, and heat the oven to 375°F. \n \nMelt the butter in a medium microwave-safe bowl until completely melted, about 1 minute. Add the olive oil, minced garlic, parsley, garlic powder, salt, and pepper and stir to combine. Set aside while you slice the bread.   \n \nIf unsliced, slice the bread into 1-inch-thick slices. Use a pastry or basting brush to coat both sides of each slice with the garlic butter.   \n \nPlace the bread on the preheated baking sheet in a single layer. Bake until golden-brown, about 12 minutes. Serve warm. \n \nRECIPE NOTES \nGrill instructions: Heat an outdoor grill to medium heat and grill the toast for 2 minutes per side.\n*/";
			Funnies[3] = "\n \n/*\nGarlic Bread: \n1 16-ounce (450 g) loaf of Italian bread or French bread \n \n1/2 cup (1 stick, 112 g) unsalted butter, softened \n \n2 large cloves garlic, smashed and minced \n \n1 heaping tablespoon of freshly chopped parsley \n \n1/4 cup (25 g) freshly grated Parmesan cheese (optional) \n \nMETHOD 1: TOASTED GARLIC BREAD \n \n1 Preheat oven to 350°F.  \n \n2 Prepare the garlic bread: Cut the loaf in half, horizontally. Mix the butter, garlic, and parsley together in a small bowl. Spread butter mixture over the the two bread halves. \n \n3 Heat in oven for 10 min: Place on a sturdy baking pan (one that can handle high temperatures, not a cookie sheet) and heat in a 350°F (175°C) oven for 10 minutes. \n \n4 Sprinkle with Parmesan (optional) and broil: Remove pan from oven. Sprinkle Parmesan cheese over bread if you want. Return to oven on the highest rack. \n \nBroil on high heat for 2-3 minutes until the edges of the bread begin to toast and the cheese (if you are using cheese) bubbles. Watch very carefully while broiling. The bread can easily go from un-toasted to burnt. \n \n5 Slice: Remove from oven, let cool a minute. Remove from pan and use a bread knife to cut into 1-inch thick slices. Serve immediately. \n \nMETHOD 2: SOFT GARLIC BREAD \n \n1 Preheat oven to 350°F. Make the butter, garlic, parsley mixture as above. \n \n2 Slice the bread and insert butter mixture: Make 1-inch thick slices into the bread, but do not go all the way through, just to the bottom crust. Put a teaspoon or two of the butter mixture between each slice, or between every other slice if you only want the garlic mixture on one side of the bread. \n \n3 Bake the garlic bread: Wrap the bread in aluminum foil and heat for 15 minutes in the 350°F (175°C) oven, until the butter has melted and the bread is warmed. \n \n4 Serve: To serve, remove from foil and present the loaf wrapped in a clean tea towel. Tear off slices to eat.\n*/";
			Funnies[4] = "\n \n/*\nPepcorn: \n20 cups popped popcorn \n \n1/2 cup butter or margarine, melted \n \n2 teaspoons paprika \n \n2 teaspoons lemon pepper \n \n1 teaspoon salt \n \n1 teaspoon garlic powder \n \n1 teaspoon onion powder \n \n1/4 teaspoon cayenne pepper \n \nAny BDG fans out there! makin some good pepcorn in me scripts :) \n \nStep 1 \nPreheat the oven to 350 degrees F (175 degrees C). Place the popped popcorn in a large roasting pan. \n \nStep 2 \nIn a small bowl, stir together the melted butter, paprika, lemon pepper, salt, garlic powder, onion powder, and cayenne pepper. Pour over the popcorn and stir until it is somewhat evenly coated. \n \nStep 3 \nBake for 15 minutes, stirring every 5 minutes. Remove from the oven and cool completely. Serve immediately, or store in an airtight container for later.\n*/";
			Funnies[5] = "\n \n/*\nPancakes: \n1 1/2 cups all-purpose flour \n \n3 1/2 teaspoons baking powder \n \n1 teaspoon salt \n \n1 tablespoon white sugar \n \n1 1/4 cups milk \n \n1 egg \n \n3 tablespoons butter, melted \n \nStep 1 \nIn a large bowl, sift together the flour, baking powder, salt and sugar. Make a well in the center and pour in the milk, egg and melted butter; mix until smooth. \n \nStep 2 \nHeat a lightly oiled griddle or frying pan over medium high heat. Pour or scoop the batter onto the griddle, using approximately 1/4 cup for each pancake. Brown on both sides and serve hot.\n*/";
			Funnies[6] = "\n \n/*\nChicken Soup: \n1 (3 pound) whole chicken \n \n4 medium (blank)s carrots, halved \n \n4 stalks celery, halved \n \n1 large onion, halved \n \nwater to cover \n \nsalt and pepper to taste \n \n1 teaspoon chicken bouillon granules \n \nStep 1 \nPut the chicken, carrots, celery and onion in a large soup pot and cover with cold water. Heat and simmer, uncovered, until the chicken meat falls off of the bones (skim off foam every so often). \n \nStep 2 \nTake everything out of the pot. Strain the broth. Pick the meat off of the bones and chop the carrots, celery and onion. Season the broth with salt, pepper and chicken bouillon to taste, if desired. Return the chicken, carrots, celery and onion to the pot, stir together, and serve.\n*/";
			Funnies[7] = "\n \n/*\nCheddar Broccoli Soup: \n1 tablespoon butter \n \n1/2 onion, chopped \n \n1/4 cup melted butter \n \n1/4 cup flour \n \n2 cups milk \n \n2 cups chicken stock \n \n1 1/2 cups coarsely chopped broccoli florets \n \n1 cup matchstick-cut carrots \n \n1 stalk celery, thinly sliced \n \n2 1/2 cups shredded sharp Cheddar cheese \n \nsalt and ground black pepper to taste \n \nStep 1 \nMelt 1 tablespoon butter in a skillet over medium-high heat. Saute onion in hot butter until translucent, about 5 minutes. Set aside. \n \nStep 2 \nWhisk 1/4 cup melted butter and flour together in a large saucepan over medium-low heat; cook until flour loses it's granular texture, adding 1 to 2 tablespoons of milk if necessary to keep the flour from burning, 3 to 4 minutes. \n \nStep 3 \nGradually pour milk into flour mixture while whisking constantly. Stir chicken stock into milk mixture. Bring to a simmer; cook until flour taste is gone and mixture is thickened, about 20 minutes. Add broccoli, carrots, sauteed onion, and celery; simmer until vegetables are tender, about 20 minutes. \n \nStep 4 \nStir Cheddar cheese into vegetable mixture until cheese melts. Season with salt and pepper to taste.\n*/";
			Funnies[8] = "\n \n/*\nNew York styled Ice Cream: \n2 cups heavy cream \n1 cup whole milk \n2/3 cup sugar \n1/8 teaspoon fine sea salt \n6 large egg yolks \n Your choice of flavoring (see note) \n  \nIn a small pot, simmer heavy cream, milk, sugar and salt until sugar completely dissolves, about 5 minutes. Remove pot from heat. In a separate bowl, whisk yolks. Whisking constantly, slowly whisk about a third of the hot cream into the yolks, then whisk the yolk mixture back into the pot with the cream. Return pot to medium-low heat and gently cook until mixture is thick enough to coat the back of a spoon (about 170 degrees on an instant-read thermometer). \n \nStrain through a fine-mesh sieve into a bowl. Cool mixture to room temperature. Cover and chill at least 4 hours or overnight. Churn in an ice cream machine according to manufacturers’ instructions. Serve directly from the machine for soft serve, or store in freezer until needed. \n \nTip \nThis recipe for ice cream base may be churned on its own, but it is meant to have flavors added. See the chart here for flavor options and directions for incorporating them into the base recipe.\n*/";
			Funnies[9] = "\n \n/*\nCrab Rangoon: \n5 oz can of crab meat drained (can be substituted with fresh or packaged crab) \n \n4 oz cream cheese softened4 oz cream cheese softened \n \n1 green onion finely sliced1 green onion finely sliced \n \n1/4 teaspoon garlic powder1/4 teaspoon garlic powder \n \n1 teaspoon Worcestershire sauce1 teaspoon Worcestershire sauce \n \n18 won ton wrappers18 won ton wrappers \n \noil for fryingoil for frying \n \nInstructions \nPreheat 1 inch of oil to 325°F over medium heat. \nIn a small bowl, gently combine crab meat, cream cheese, green onion, garlic powder, and Worcestershire sauce. \nLayout 3 wonton wrappers at a time. Place 2 teaspoons of the filling in the center of each. Dab the edges with water and fold the two opposite corners together to form a triangle. Wet the tips of the triangle and fold inward. Continue until all of your filling is used up. \n \nTo Fry \nDrop the wontons into the hot oil for 2-3 minutes or until brown and crispy. Drain on paper towels. \n \nTo Bake \nPreheat oven to 425°F. Line a baking pan with parchment paper. \nAssemble wontons as above and spray each with cooking spray. Bake 12-14 minutes.\n*/";
			Funnies[10] = "\n \n/*\nCurrywurst: \n \nCourtesy of Dranif! \n \nStep 1: \nGet a rather thick sausage and cut it into pieces (and warm it up) \n \nStep 2: \nMake some fries as garnish \n \nStep 3: \nAdd some (flavoured) Ketchup \n \nStep 4: \nAdd curry spice\n*/";
			Funnies[11] = "\n \n/*\n3 in 1 Fry sauce combo: \n \nFrench Fry Sauce \n1/3 cup ketchup \n2/3 cup mayonnaise \n1 tsp pickle juice \n \nGarlic Aioli \n1 cup mayonnaise \n1 TBS garlic (minced) \n2 TBS lemon juice \n1/2 tsp salt \n1 pinch black pepper \n \nCheese Sauce \n8 oz Velveeta Cheese \n1/2 cup milk \nInstructions \n \nFry Sauce \nCombine ketchup, mayonnaise, pickle juice in a medium sized bowl \nStir together until smooth \n \nGarlic Aioli \nCombine your mayo, lemon juice, garlic, salt, pepper in a medium bowl, \nStir until everything is smooth \nRefrigerate for 30 minutes before serving \n \nCheese Sauce \nCut your Velveeta cheese into small cubes \nIn a small pot over medium high heat, put your cheese cubes and milk \nStirring regularly, allow cheese to melt into milk, until smooth\n*/";

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //It's a step in the right direction however not what I'm looking for specifically
            string pathString = System.IO.Path.Combine(path, "Output");
            System.IO.Directory.CreateDirectory(pathString);

            if (String.IsNullOrEmpty(IceStatueText.Text)) { IceStatueText.Text = "StaticMesh'HatinTime_Habboi.models.hat_kid_crystal'"; }
			if (String.IsNullOrEmpty(PlayerIconText.Text)) { PlayerIconText.Text = "None"; }
			if (String.IsNullOrEmpty(PrefixText.Text)) { PrefixText.Text = "Kido"; }
			if (String.IsNullOrEmpty(PlayerNameText.Text)) { PlayerNameText.Text = "PLAYERNAME"; }
			if (String.IsNullOrEmpty(FullModelText.Text)) { FullModelText.Text = "None"; }
			if (String.IsNullOrEmpty(PonytailText.Text)) { PonytailText.Text = "-1"; }
			if (String.IsNullOrEmpty(FaceText.Text)) { FaceText.Text = "-1"; }
			if (String.IsNullOrEmpty(EyesText.Text)) { EyesText.Text = "-1"; }
			if (String.IsNullOrEmpty(BaseEXPText.Text)) { BaseEXPText.Text = "Hat_ExpressionComponent_HatKid"; }
			if (String.IsNullOrEmpty(BText.Text)) { BText.Text = "174"; }
			if (String.IsNullOrEmpty(GText.Text)) { GText.Text = "217"; }
			if (String.IsNullOrEmpty(RText.Text)) { RText.Text = "255"; }
            if (String.IsNullOrEmpty(PitchText.Text)) { PitchText.Text = "1"; }


            string fileName = PrefixText.Text+"_Player_"+PlayerNameText.Text+".uc";
			pathString = System.IO.Path.Combine(pathString, fileName);


			Random rand = new Random();
			int index = rand.Next(Funnies.Length);


			if (!System.IO.File.Exists(pathString))
			{
				using (StreamWriter writer = new StreamWriter(pathString))
				{
					writer.WriteLine("class " + PrefixText.Text + "_Player_" + PlayerNameText.Text + " extends Hat_Player_HatKid;");
					writer.WriteLine(Funnies[index]);
                    writer.WriteLine("\n\n\nsimulated function AudioComponent PlayVoice(SoundCue c, optional float relaxtime = 0, optional bool ignorerelax, optional bool isconversation) \n{ \n	local AudioComponent a; \n \n	a = Super.PlayVoice(c, relaxtime, ignorerelax); \n \n	if (a != None && !isconversation) \n	{ \n		a.PitchMultiplier = " + PitchText.Text + "; \n	} \n	return a; \n} \n\ndefaultproperties\n{\n	Begin Object Name=Mesh0\n		SkeletalMesh=" + FullModelText.Text + "\n		AnimSets(0)=AnimSet'HatInTime_Characters_HatKid.AnimSet.HatKidV2_Anims'\n		AnimSets(1)=AnimSet'HatInTime_Characters_HatKid.AnimSet.HatKidV2_Attack_Anims'\n		AnimSets(2)=AnimSet'HatInTime_Characters_HatKid2.AnimSet.HatKidV2_Cruise'\n\n		AnimTreeTemplate = AnimTree'HatInTime_Characters.AnimTree.PlatformPlayer_AnimTree'\n		PhysicsAsset=PhysicsAsset'HatinTime_Characters_CoPartner.Physics.CoPartner_Physics'\n		Translation=(Z=-36, Y=0, X=0)\n        \n		bNoSelfShadow=true\n	End Object\n	\n	Begin Object Name=OccludedMesh0\n		Materials(0)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(1)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(2)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(3)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(4)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(5)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(6)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(7)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(8)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(9)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(10)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(11)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(12)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(13)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(14)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(15)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(16)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		Materials(17)=Material'HatInTime_Characters.Materials.OccludedMaterial'\n		SkeletalMesh=" + FullModelText.Text + "\n	End Object\n	\n	Begin Object Class=" + BaseEXPText.Text + " Name=Expression1\n	End Object\n	Components.Add(Expression1);\n	ExpressionComponent = Expression1;\n	\n	Begin Object Name=StatueFall0\n		StaticMesh=" + IceStatueText.Text + "\n		Translation=(Z=15, Y=0, X=0)\n	End Object\n	");
                    
                    if (checkBox1.Checked)
                    {

                        String[] SoundLines = new String[30];

                        for (var num = 0; num < TestBox.Lines.Length; num++)
                        {
                            if (num < 30)
                            {
                                SoundLines[num] = TestBox.Lines[num];
                            }
                        }

                        for (var num = 0; num < 30; num++)
                        {
                            if (String.IsNullOrEmpty(SoundLines[num]))
                            {
                                SoundLines[num] = "None";
                            }

                            if (num == 0) { writer.Write("	VoiceJump = "); }
                            if (num == 1) { writer.Write("	VoiceWallImpact = "); }
                            if (num == 2) { writer.Write("	VoiceAttack = "); }
                            if (num == 3) { writer.Write("	VoiceHurt = "); }
                            if (num == 4) { writer.Write("	VoiceHurtPant = "); }
                            if (num == 5) { writer.Write("	VoiceHookshotCling = "); }
                            if (num == 6) { writer.Write("	VoiceMonitorClick = "); }
                            if (num == 7) { writer.Write("	VoiceCollectedAll = "); }
                            if (num == 8) { writer.Write("	VoiceFreeCitizen = "); }
                            if (num == 9) { writer.Write("	VoiceLongFallNoDmg = "); }
                            if (num == 10) { writer.Write("	VoiceNPCTease = "); }
                            if (num == 11) { writer.Write("	VoiceVacuumSpin = "); }
                            if (num == 12) { writer.Write("	VoiceShopItemExamine = "); }
                            if (num == 13) { writer.Write("	VoiceShopLeave = "); }
                            if (num == 14) { writer.Write("	VoiceChemicalExplosion = "); }
                            if (num == 15) { writer.Write("	VoiceHatStolen = "); }
                            if (num == 16) { writer.Write("	VoiceDivaGreet = "); }
                            if (num == 17) { writer.Write("	HelpAbilityHmm = "); }
                            if (num == 18) { writer.Write("	VoiceTakePainting = "); }
                            if (num == 19) { writer.Write("	VoiceBurnPainting = "); }
                            if (num == 20) { writer.Write("	VoiceCounting(1) = "); }
                            if (num == 21) { writer.Write("	VoiceCounting(2) = "); }
                            if (num == 22) { writer.Write("	VoiceCounting(3) = "); }
                            if (num == 23) { writer.Write("	VoiceCounting(4) = "); }
                            if (num == 24) { writer.Write("	VoiceCounting(5) = "); }
                            if (num == 25) { writer.Write("	VoiceHatStitch(0) = "); }
                            if (num == 26) { writer.Write("	VoiceHatStitch(1) = "); }
                            if (num == 27) { writer.Write("	VoiceMurderClueGotcha = "); }
                            if (num == 28) { writer.Write("	DeathJingle = "); }
                            if (num == 29) { writer.Write("	EndlessPitDeathJingle = "); }

                            writer.WriteLine(SoundLines[num] + ";");
                        }
                        writer.WriteLine("");
                    }
                    writer.WriteLine("\n\n	// properties\n	ObjectiveActorClass = class'" + PrefixText.Text + "_ObjectiveActor_" + PlayerNameText.Text + "'\n	CanWearHatKidCosmetics = true\n	  MaterialIndexEyes = " + EyesText.Text + "\n      MaterialIndexFace = " + FaceText.Text + "\n	  MaterialSectionPonytail = " + PonytailText.Text + "\n	  \n	SkinColor = (R=" + RText.Text + ",G=" + GText.Text + ",B=" + BText.Text + ")\n\n	\n	PlayerVisualClass(0) = class'" + PrefixText.Text + "_Player_" + PlayerNameText.Text + "'\n}\n\nsimulated function UpdateSkin()\n{\n	Super.UpdateSkin();\n\n\n	Hat_InventoryManager(InvManager).RemoveCosmeticUpperBody();\n	Hat_InventoryManager(InvManager).RemoveCosmeticLegs();\n\n}\n\nsimulated event Tick(float d)\n{\n	Super.Tick(d);\n\n}\n\n\nstatic function ConvertGhostPartyPlayer(Hat_GhostPartyPlayer gp)\n{\n	if (gp.SkeletalMeshComponent == None) return;\n	gp.SkeletalMeshComponent.SetSkeletalMesh(" + FullModelText.Text + ");\n	gp.SkeletalMeshComponent.SetPhysicsAsset(PhysicsAsset'HatinTime_Characters_CoPartner.Physics.CoPartner_Physics');\n	gp.SkeletalMeshComponent.SetMaterial(0, None);\n	gp.SkeletalMeshComponent.SetMaterial(1, None);\n	gp.SkeletalMeshComponent.SetMaterial(2, None);\n	gp.SkeletalMeshComponent.SetMaterial(3, None);\n	gp.SkeletalMeshComponent.SetMaterial(4, None);\n	gp.SkeletalMeshComponent.SetMaterial(5, None);\n}\n\nstatic function ConvertNPCPlayer(Hat_NPC_Player npc)\n{\n	local Hat_ExpressionComponent exp;\n\n	npc.DisableHats = true;\n	npc.DisableMasks = true;\n	npc.DisableUpperBody = true;\n	npc.DisableLegs = true;\n	npc.AddDefaultInventory();\n\n	// fix face\n	npc.SkeletalMeshComponent.SetMaterial(0, default.Mesh.GetMaterial(0));\n	npc.SkeletalMeshComponent.SetMaterial(1, default.Mesh.GetMaterial(1));\n	npc.SkeletalMeshComponent.SetMaterial(2, default.Mesh.GetMaterial(2));\n	npc.SkeletalMeshComponent.SetMaterial(3, default.Mesh.GetMaterial(3));\n	npc.SkeletalMeshComponent.SetMaterial(4, default.Mesh.GetMaterial(4));\n	npc.SkeletalMeshComponent.SetMaterial(5, default.Mesh.GetMaterial(5));\n	exp = new class'" + BaseEXPText.Text + "';\n	npc.DetachComponent(npc.Expression);\n	npc.AttachComponent(exp);\n	npc.Expression = exp;\n	npc.Expression.Init(npc);\n}");

                }
            }

			pathString = System.IO.Path.Combine(path, "Output");
			fileName = PrefixText.Text + "_ObjectiveActor_" + PlayerNameText.Text + ".uc";
			pathString = System.IO.Path.Combine(pathString, fileName);

			if (!System.IO.File.Exists(pathString))
			{
				using (StreamWriter writer = new StreamWriter(pathString))
				{
					writer.WriteLine("class " + PrefixText.Text + "_ObjectiveActor_" + PlayerNameText.Text + " extends Hat_ObjectiveActor_HatKid;\n\ndefaultproperties\n{\n\tHUDIcon = " + PlayerIconText.Text + "; \n}");
				}
			}
		}

		private void Output_Click(object sender, EventArgs e)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //It's a step in the right direction however not what I'm looking for specifically
			string pathString = System.IO.Path.Combine(path, "Output");
			System.IO.Directory.CreateDirectory(pathString);
			Process.Start(pathString);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void FullModelText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TestBox.Show();
                textBox1.Show();
            }
            else
            {
                TestBox.Hide();
                textBox1.Hide();
            }
        }
    }
}
