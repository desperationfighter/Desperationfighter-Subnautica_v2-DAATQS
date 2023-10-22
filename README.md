# Desperationfighter-Subnautica_v2-DAATQS

This Mod is the Updates Version supporting Subnautica v2.x and Nautilus. 
If you use Legency (with QMM and SML) then please use my old Mod.

***

DAATQS - Disables the Auto adding of items to the Quickslots. 
For example picking up a Fish will not result in adding it to the Quickslotbar. 
Only you choose what Item you want in the Quickslotbar. 
You can use your own custom list of Item/Techtypes that should be Auto added.

Options: The Mod add a Ingame Menu under Settings->Mods where you cann enable or disable the mod live if you wish. 
Also there is a switch to enable or disable your Custom List live while you are ingame. 
So for example it is possible to disable your list temporary while you transfer your stuff between lockers.

Adding your Own Techtype to the Mods:

    Go to the BepInEx Config Folder after first Game start with Mod. 
    There you will see a "AllowList.json" File.
    Open it with a text editor while the game is closed.
    Add your own Techtypes to the List (see: https://subnautica.fandom.com/wiki/Spawn_IDs)


Example
﻿{
    "TechType": ["builder","Knife"]
}

Know Bugs:

    Items get rearranged after Safegame reload. When a Quickslot is not filed.
    ->Sadly a Vanilla Bug. Currently nothing i can do.
