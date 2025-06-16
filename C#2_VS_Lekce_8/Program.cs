namespace C_2_VS_Lekce_8
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Human arabela = new Princess();
            Human krason = new Prince();
            Human gandalf = new Wizard();

            List<Human> humans = new List<Human> { arabela, krason, gandalf };
            foreach (Human human in humans)
            {
                human.IntroduceYourself();
            }

            foreach (DancingHumans dancingHuman in humans.OfType<MagicHuman>)
            {
                dancingHuman.StartDancing();
                dancingHuman.StopDancing();
            }

            if (gandalf is MagicHuman)
            {
                ((MagicHuman)gandalf).BecomeInvisible();
                (gandalf as MagicHuman).BecomeVisible();
            }

            
        }
    }
}
