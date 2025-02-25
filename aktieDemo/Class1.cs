namespace aktieDemo
{
    /// <summary>
    /// Repræsenterer en aktie med købskurs, salgskurs og antal aktier.
    /// </summary>
    public class Aktie
    {
        /// <summary> Navnet på aktien. </summary>
        public string Aktienavn { get; set; }

        /// <summary> Købskursen for aktien. </summary>
        public double Købskurs { get; set; }

        /// <summary> Salgskursen for aktien. </summary>
        public double Salgskurs { get; set; }

        /// <summary> Antal aktier handlet. </summary>
        public int AntalAktier { get; set; }

        /// <summary>
        /// Initialiserer en ny instans af Aktie-klassen.
        /// </summary>
        /// <param name="aktienavn">Navnet på aktien.</param>
        /// <param name="købskurs">Prisen aktien blev købt for.</param>
        /// <param name="salgskurs">Prisen aktien blev solgt for.</param>
        /// <param name="antalAktier">Antallet af aktier.</param>
        public Aktie(string aktienavn, double købskurs, double salgskurs, int antalAktier)
        {
            Aktienavn = aktienavn;
            Købskurs = købskurs;
            Salgskurs = salgskurs;
            AntalAktier = antalAktier;
        }

        /// <summary>
        /// Beregner afkastet (profit eller tab) baseret på købskurs, salgskurs og antal aktier.
        /// </summary>
        /// <returns>Afkastet i form af en monetær værdi.</returns>
        public double Afkast()
        {
            return (Salgskurs - Købskurs) * AntalAktier;
        }
    }
}
