public class Mage : NPC {
    public int Mana;
    public void CastHealSpell() {
        if(Mana > 0) {
            this.Mana--;
            Health++;
        }
    }
}