Def Combinaciones(arreglo, n, r, indice, combinacion)


    if size(combinacion) == r:
		print combinacion
		return
	end
		
	if indice >= n:
		return
    end


    Combinaciones(arreglo, n, r, indice + 1, combinacion)

    combinacion.add(arreglo[indice])

    Combinaciones(arreglo, n, r, indice + 1, combinacion)

    combinacion.remove(combinacion.size() - 1)


end

Def main(string[] ):string
	
	int[] arreglo = entrada de un arreglo
	int n = arreglo.lenght
	int r = entrada de número de combinaciones
	
	Combinaciones(arreglo, n, r, 0, nuevo arreglo)

end
