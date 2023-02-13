namespace APIWarsUser.ActionClass.HelperClass.Drone
{
    public class Vision
    {
        private long Ox { get; set; }
        private long Oy { get; set; }
        private decimal Property { get; set; }

        /// <summary>
        /// Класс для обработки данных
        /// </summary>
        /// <param name="OXn">Координата дрона по оси X</param>
        /// <param name="OYn">Координата дрона по оси Y</param>
        /// <param name="Property">Уникальное значение дрона</param>
        public Vision(long OXn, long OYn, decimal Property)
        {
            this.Ox = OXn;
            this.Oy = OYn;
            this.Property = Property;
        }

        public long[] XY1()
        {
            return new long[] {
                    Ox - Convert.ToInt64(Property),
                    Oy + Convert.ToInt64(Property)
                };
        }

        public long[] XY2()
        {
            return new long[] {
                    Ox + Convert.ToInt64(Property),
                    Oy - Convert.ToInt64(Property)
                };
        }
    }
}
