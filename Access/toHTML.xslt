<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<html>
			<body>
				<h2>   ..les données supprimées .. </h2>
				
				<!-- pour les eleves  .. -->
				
				<h3> eleves </h3>
				<table border="1">
					<tr bgcolor="#9acd32">

						<th style="text-align:left">id</th>
						<th style="text-align:left">code</th>
						<th style="text-align:left">nom</th>
						<th style="text-align:left">prenom</th>
						<th style="text-align:left">niveau</th>
						<th style="text-align:left">code_filiere</th>

					</tr>
					<xsl:for-each select="tables/Eleves/Eleve">
						<tr>
							<td>
								<xsl:value-of select="id"/>
							</td>
							<td>
								<xsl:value-of select="code"/>
							</td>
							<td>
								<xsl:value-of select="nom"/>
							</td>
							<td>
								<xsl:value-of select="prenom"/>
							</td>
							<td>
								<xsl:value-of select="niveau"/>
							</td>
							<td>
								<xsl:value-of select="code_filiere"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>


				<!-- pour les filieres   .. -->
				<h3>filieres</h3>
				<table border="1">
					<tr bgcolor="#9acd32">

						<th style="text-align:left">id</th>
						<th style="text-align:left">code</th>
						<th style="text-align:left">designation</th>


					</tr>
					<xsl:for-each select="tables/Filieres/Filiere">
						<tr>
							<td>
								<xsl:value-of select="id"/>
							</td>
							<td>
								<xsl:value-of select="code"/>
							</td>
							<td>
								<xsl:value-of select="designation"/>
							</td>

						</tr>
					</xsl:for-each>
				</table>
				<!-- pour les matiers-->
				<h3>matieres</h3>

				<table border="1">
					<tr bgcolor="#9acd32">

						<th style="text-align:left">id</th>
						<th style="text-align:left">code</th>
						<th style="text-align:left">designation</th>
						<th style="text-align:left">VH</th>
						<th style="text-align:left">code_module</th>

					</tr>
					<xsl:for-each select="tables/Matieres/Matiere">
						<tr>
							<td>
								<xsl:value-of select="id"/>
							</td>
							<td>
								<xsl:value-of select="code"/>
							</td>
							<td>
								<xsl:value-of select="designation"/>
							</td>
							<td>
								<xsl:value-of select="VH"/>
							</td>
							<td>
								<xsl:value-of select="code_module"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>

				<!-- pour les modules-->

				<h3>Modules</h3>
				<table border="1">
					<tr bgcolor="#9acd32">

						<th style="text-align:left">id</th>
						<th style="text-align:left">code</th>
						<th style="text-align:left">nom</th>
						<th style="text-align:left">niveau</th>
						<th style="text-align:left">semestre</th>
						<th style="text-align:left">code_filiere</th>

					</tr>
					<xsl:for-each select="tables/Modules/Module">
						<tr>
							<td>
								<xsl:value-of select="id"/>
							</td>
							<td>
								<xsl:value-of select="code"/>
							</td>
							<td>
								<xsl:value-of select="nom"/>
							</td>
							<td>
								<xsl:value-of select="niveau"/>
							</td>
							<td>
								<xsl:value-of select="semestre"/>
							</td>
							<td>
								<xsl:value-of select="code_filiere"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
				<!-- pour les moyennes-->
				<h3>pour la moyenne </h3>
				<table border="1">
					<tr bgcolor="#9acd32">

						<th style="text-align:left">id</th>
						<th style="text-align:left">code_eleve</th>
						<th style="text-align:left">code_filiere</th>
						<th style="text-align:left">niveau</th>
						<th style="text-align:left">moyenne</th>

					</tr>
					<xsl:for-each select="tables/Moyennes/Moyenne">
						<tr>
							<td>
								<xsl:value-of select="id"/>
							</td>
							<td>
								<xsl:value-of select="code_eleve"/>
							</td>
							<td>
								<xsl:value-of select="code_filiere"/>
							</td>
							<td>
								<xsl:value-of select="niveau"/>
							</td>
							<td>
								<xsl:value-of select="moyenne"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
				<!-- pour les notes-->
				<h3>pour les notes ..</h3>


				<table border="1">
					<tr bgcolor="#9acd32">

						<th style="text-align:left">id</th>
						<th style="text-align:left">code_eleve</th>
						<th style="text-align:left">code_matiere</th>
						<th style="text-align:left">note</th>


					</tr>
					<xsl:for-each select="tables/Notes/Note">
						<tr>
							<td>
								<xsl:value-of select="id"/>
							</td>
							<td>
								<xsl:value-of select="code_eleve"/>
							</td>
							<td>
								<xsl:value-of select="code_matiere"/>
							</td>
							<td>
								<xsl:value-of select="note"/>
							</td>

						</tr>
					</xsl:for-each>
				</table>



			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
