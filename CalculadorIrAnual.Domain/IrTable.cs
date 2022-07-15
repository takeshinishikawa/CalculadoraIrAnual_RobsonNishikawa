namespace CalculadorIrAnual.Domain
{
    public static class IrTable
    {
        public static List<TableLine> Table = new ()
        {
            new TableLine { MaxRange = 22847.76, Aliquot = 0, ValueToDeduce = 0 },
            new TableLine { MaxRange = 33919.80, Aliquot = 0.075, ValueToDeduce = 1713.58 },
            new TableLine { MaxRange = 45012.60, Aliquot = 0.15, ValueToDeduce = 4257.57 },
            new TableLine { MaxRange = 55976.16, Aliquot = 0.225, ValueToDeduce = 7633.51 },
            new TableLine { MaxRange = double.MaxValue, Aliquot = 0.275, ValueToDeduce = 10432.32 }
        };
        public static void GetLine(double value, ref TableLine line)
        {
            foreach (TableLine tableLine in Table)
            {
                line = tableLine;
                if (value <= tableLine.MaxRange)
                    break;
            }
            return;
        }
    }
}
//Faixas de Valor ($)	        Aliquota Deduzir
//Até 22.847,76	                Isento	Isento
//De 22.847,77 a 33.919,80	    0,075	1.713,58
//De R$ 33.919,81 a 45.012,60	0,150	4.257,57
//De R$ 45.012,61 a 55.976,16	0,225	7.633,51
//Acima de 55.976,16	        0,275	10.432,32
