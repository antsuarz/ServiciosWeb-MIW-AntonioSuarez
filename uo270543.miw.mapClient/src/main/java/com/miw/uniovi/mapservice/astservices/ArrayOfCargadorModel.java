
package com.miw.uniovi.mapservice.astservices;

import java.util.ArrayList;
import java.util.List;
import jakarta.xml.bind.annotation.XmlAccessType;
import jakarta.xml.bind.annotation.XmlAccessorType;
import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para ArrayOfCargadorModel complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType name="ArrayOfCargadorModel"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="CargadorModel" type="{http://schemas.datacontract.org/2004/07/WS.ChargerService.Asturias.Application.Model}CargadorModel" maxOccurs="unbounded" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ArrayOfCargadorModel", propOrder = {
    "cargadorModel"
})
public class ArrayOfCargadorModel {

    @XmlElement(name = "CargadorModel", nillable = true)
    protected List<CargadorModel> cargadorModel;

    /**
     * Gets the value of the cargadorModel property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the Jakarta XML Binding object.
     * This is why there is not a <CODE>set</CODE> method for the cargadorModel property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getCargadorModel().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link CargadorModel }
     * 
     * 
     */
    public List<CargadorModel> getCargadorModel() {
        if (cargadorModel == null) {
            cargadorModel = new ArrayList<CargadorModel>();
        }
        return this.cargadorModel;
    }

}
