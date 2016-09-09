using System;
using System.Windows.Forms;
using System.IO.Ports;

public class CM1K
{
    // Коды команд 
    public const byte READ_CM1K_COMMAND = 0x04;
    public const byte WRITE_CM1K_COMMAND = 0x08;
    // CM1K neuron registers addresses
    public const byte NCR 		=	(0x00);	// Neuron Context Register
    public const byte COMP 		=	(0x01);	// Component
    public const byte LCOMP 	=	(0x02);	// Last Component
    public const byte INDEXCOMP = 	(0x03);	// Component index
    public const byte DIST 		=	(0x03);	// Distance register
    public const byte CAT 		=	(0x04);	// Category register
    public const byte AIF 		=	(0x05);	// Active Influence Field
    public const byte MINIF 	=	(0x06);	// Minimum Influence Field
    public const byte MAXIF 	=	(0x07);	// Maximum Influence Field
    public const byte TESTCOMP 	=	(0x08); // Test Component 
    public const byte TESTCAT 	=	(0x09);	// Test Category

    public const byte NID 		=	(0x0A);	// Neuron Identifier
    public const byte GCR 		=	(0x0B);	// Global Control Register
    public const byte RESET_CHAIN =	(0x0C);	// Points to the first neuron of the chain
    public const byte NSR 		=	(0x0D);	// Network Status Register
    public const byte POWERSAVE =	(0x0E);	// Dummy register
    public const byte FORGET 	=	(0x0F);	// Clear the neuron’s category register
    public const byte NCOUNT 	=	(0x0F);	// NR - Number of committed neurons //SR - Index of the neuron pointed in the chain

    public const byte TOP 		=	(0x11);	// Top corner of the ROI in pixels
    public const byte LEFT 		=	(0x12);	// Left corner of the ROI in pixels
    public const byte WIDTH 	=	(0x13);	// Nominal width of the ROI in pixels
    public const byte HEIGH 	=	(0x14);	// Nominal height of the ROI in pixels
    public const byte BWIDTH 	=	(0x15);	// Width of a primitive block in pixels
    public const byte BHEIGH 	=	(0x16);	// Height of a primitive block in pixels
    public const byte RSR 		=	(0x1C);	// Recognition Status Register	
    public const byte RTDIST 	=	(0x1D);	// Real-time distance, or distance of top firing neuron
    public const byte RTCAT     = (0x1F);	// Reset the ROI to default

    /*
     Разрешен небезопасный код: Проект-свойства-вкладка Сборка-Разрешить небезопасный код.
     */

    int Recognize(byte[] vector, int length, int K, int[] distance, int[] category, int[] Nid)
    {
        return 0;
    }
    
    public static int Learn(byte[] vector, int length, int category)
    {
        return 0;
    }
    
    public void ClearNeurons()
    {
        //int temp = 0;
        
        //temp = 10;
        if (this.TextChanger != null) this.TextChanger("2222");
    }
    public ChangeTextDelegate TextChanger = null;
    
    public static int CommittedNeurons()
    {
        return 0;
    }

    unsafe public static int ReadNeurons(byte* neurons, int ncount)
    {
        return 0;
    }

    unsafe public static int WriteNeurons(byte* neurons, int ncount)
    {
        return 0;
    }

    unsafe public static int SaveNeurons(byte* neurons)
    {
        return 0;
    }

    unsafe public static int LoadNeurons(byte* neurons)
    {
        return 0;
    }
    
    public CM1K()
	{
	}
}

public delegate void ChangeTextDelegate(string text);