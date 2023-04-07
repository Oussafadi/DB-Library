<?xml version="1.0" encoding="UTF-8"?><xsl:stylesheet xmlns:fo="http://www.w3.org/1999/XSL/Format" xmlns:fox="http://xmlgraphics.apache.org/fop/extensions" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="tables">

<fo:root>
			<fo:layout-master-set>
				<fo:simple-page-master master-name="Letter" page-height="11in" page-width="8.5in">
					<fo:region-body background-color="#fff" margin="1in" region-name="only_region"/>
				</fo:simple-page-master>
			</fo:layout-master-set>
			<fo:page-sequence master-reference="Letter">
				<fo:flow flow-name="only_region">
					<xsl:apply-templates/>
				</fo:flow>
			</fo:page-sequence>
		</fo:root>
</xsl:template>
    <xsl:template match="/">
       
  
         <fo:block border="3px solid red" font-weight="bold" margin-bottom="0.75cm" text-align="center">
            les données supprimées
           </fo:block>
         

             <!-- pour les eleves -->
               <fo:table background-color="#FFE4C4" border="2px solid #2F4F4F " padding-bottom="0.75cm" padding-top="15px">
                 <fo:table-body>
                     
                                    
                            <fo:table-row background-color="#A9A9A9" border-bottom="2px solid #2F4F4F">

                                          <fo:table-cell border-left="1px solid #2F4F4F" border-right="1px solid #2F4F4F">
                                                 <fo:block> id </fo:block>
                                                 
                                          </fo:table-cell>
                                          <fo:table-cell border-left="1px solid #2F4F4F" border-right="1px solid #2F4F4F">
                                                 <fo:block> code </fo:block>
                                                 
                                          </fo:table-cell>
                                          <fo:table-cell border-left="1px solid #2F4F4F" border-right="1px solid #2F4F4F">
                                                 <fo:block>nom</fo:block>      
                                                        
                                          </fo:table-cell>
                                          <fo:table-cell border-left="1px solid #2F4F4F" border-right="1px solid #2F4F4F">
                                                 <fo:block> prenom </fo:block>            
                                          </fo:table-cell>

                                          <fo:table-cell border-left="1px solid #2F4F4F" border-right="1px solid #2F4F4F">
                                                 <fo:block> niveau </fo:block>            
                                          </fo:table-cell>

                                          <fo:table-cell border-left="1px solid #2F4F4F" border-right="1px solid #2F4F4F">
                                                 <fo:block> code_filiere </fo:block>            
                                          </fo:table-cell>

                            </fo:table-row>
                                               
                   
                    
                         <xsl:for-each select="/tables/Eleves/Eleve">
                            <fo:table-row border-bottom="1px solid #2F4F4F">
                                                        
                                          </fo:table-cell>
                                          <fo:table-cell border-left="1px solid #2F4F4F" border-right="1px solid #2F4F4F">
                                          
                                          <fo:block>  <xsl:value-of select="id"/> </fo:block>      
                                          <fo:block>  <xsl:value-of select="code"/>   </fo:block>
                                          
                                          <fo:block>  <xsl:value-of select="nom"/> </fo:block>      
                                          <fo:block>  <xsl:value-of select="prenom"/>   </fo:block>
                                          
                                          <fo:block>  <xsl:value-of select="niveau"/> </fo:block>      
                                          <fo:block>  <xsl:value-of select="code_filiere"/>   </fo:block>
                                          </fo:table-cell>
                                   
                            </fo:table-row>
                        </xsl:for-each>
              </fo:table-body>
              </fo:table>


          
               
        
</xsl:template>
</xsl:stylesheet>