
package com.miw.uniovi.mapservice.astservices;

import jakarta.xml.bind.annotation.XmlAccessType;
import jakarta.xml.bind.annotation.XmlAccessorType;
import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import jakarta.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para anonymous complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="GetCargadoresResult" type="{http://schemas.datacontract.org/2004/07/WS.ChargerService.Asturias.Application.Model}ArrayOfCargadorModel"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "getCargadoresResult"
})
@XmlRootElement(name = "GetCargadoresResponse", namespace = "http://ws.chargerservice.asturias/application/")
public class GetCargadoresResponse {

    @XmlElement(name = "GetCargadoresResult", namespace = "http://ws.chargerservice.asturias/application/", required = true, nillable = true)
    protected ArrayOfCargadorModel getCargadoresResult;

    /**
     * Obtiene el valor de la propiedad getCargadoresResult.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfCargadorModel }
     *     
     */
    public ArrayOfCargadorModel getGetCargadoresResult() {
        return getCargadoresResult;
    }

    /**
     * Define el valor de la propiedad getCargadoresResult.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfCargadorModel }
     *     
     */
    public void setGetCargadoresResult(ArrayOfCargadorModel value) {
        this.getCargadoresResult = value;
    }

}
