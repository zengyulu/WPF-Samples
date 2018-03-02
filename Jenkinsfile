pipeline {
  agent {
    node {
      label 'NET'
    }
    
  }
  stages {
	stage('Initial') {
		steps {
			echo "Running Build #${env.BUILD_ID}!"
			//echo "Clean workspace on agent"
			//bat "del ${NUGET_FOLDER}\\*.* /s /q"
			//bat "rmdir ${NUGET_FOLDER}\\* /q"
		}
	}
  
    stage('Checkout') {
      steps {
        echo "Check out from Git repository ..."
		git(url: 'https://github.com/zengyulu/WPF-Samples', branch: 'master')
      }
    }
	
	stage('NuGet Restore') {
		steps {
			echo "Nuget restore packages"
			bat "${NUGET_FULLPATH} restore ${WORKSPACE}\\${VS_SOLUTION} -OutputDirectory C:\\nuget"
		}
	}
	
	stage('MSBuild') {
		steps {
			echo "Start MSBuild"
			script {
				//def msbuild = tool name: 'MSBuild', type: 'hudson.plugins.msbuild.MsBuildInstallation'
				bat "${MSBUILD_PATH} ${WORKSPACE}\\${VS_SOLUTION} /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
			}
		}
	}
  }
  environment {
	NUGET_FOLDER = 'C:\\nuget'
	NUGET_FULLPATH = 'C:\\nuget\\nuget.exe'
	VS_SOLUTION = 'WPFSamples.sln'
	MSBUILD_PATH = '\"C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\msbuild.exe\"'
  }
}