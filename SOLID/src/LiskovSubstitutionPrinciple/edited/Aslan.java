package LiskovSubstitutionPrinciple.edited;

public class Aslan implements IEtleBeslen {

	@Override
	public boolean etleBeslenen() {
		System.out.println("et�il");
		return true;
	}

}
