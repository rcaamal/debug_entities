Insert Into [dbo].[Creatures]([Name], [Size], [Type], [SubType], [Aligment], [ArmorClass], [HitPoints], [HitDice], [Strength], [Dexterity], [Constitution], [Intelligence], [Wisdom], [Charisma],[Languages], [ChallangeRating], [Speed], [Proficiencies], [DamageResistance], [DamageVulnerability], [DamageImmunity], [ConditionImmunity], [Senses], [SpecialAbility]) Values
	('Adult Black Dragon', 'Huge', 'Dragon', 'Null', 'Chaotic Evil', '19', '195', '17d12', '23', '14', '21', '14', '13', '17','Common, Draconic', '14',
	[{"Name" : "Walk", "Speed" : "40ft"}, {"Name" : "Fly", "Speed" : "80ft"}, {"Name" : "Swim", "Speed" : "40ft"}],
	[{"Name" : "Saving Throw Dexterity", "Value" : "7"}, {"Name" : "Saving Throw Constitution", "Value" : "10"}, {"Name" : "Saving Throw Wisdom", "Value" : "6"}, {"Name" : "Saving Throw Charisma", "Value" : "11"}, {"Name" : "Perception", "Value" : "11"}, {"Name" : "Stealth", "7"}],
	[{}],
	[{}],
	[{"Name" : "Acid"}],
	[{}],
	[{"Name" : "Blindsight", "Value" : "60ft"}, {"Name" : "Dark Vision", "Value" : "120ft"}, {"Name" : "Passive Perception", "Value" : "21"}],
	[{"Name" : "Amphibious", "Description" : "The dragon can breathe air and water."}, {"Name" : "Legendary Resistance", "Description" : "If the dragon fails a saving throw, it can choose to succeed instead."}, {"Usage" : "3 per day"}]	
	);